'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    Promise = require('bluebird'),
    Mongoose = require('mongoose'),
    Book = Mongoose.model('Book'),
    Order = Mongoose.model('Order');

module.exports = function (server) {

	/*
	 * Route for register order
	 * Method:  POST
	 * Params:  user - User who made the order
	 *          books - Ordered books
	 *
	 * Returns: Order object with ID, total, ...
     */

    server.route({
        path: '/order',
        method: 'POST',
        config: {
            validate: {
                payload: {
                    user: Joi.object().required(),
                    books: Joi.array().required()
                }
            },
            handler: function (request, reply) {
                Jwt.verify(request.payload.user.token)
                    .then((decoded) => {

                        // Create Order object
                        var order = new Order({
                            status: 'Waiting for dispatch', // TODO: Change to integer?
                            total: 0,
                            user: {
                                _id: decoded,
                                name: request.payload.user.name,
                                address: request.payload.user.address,
                                email: request.payload.user.email
                            },
                            books: []
                        });

                        // Iterate over requested books to update order object's books
                        Promise.each(request.payload.books, function (book) {
                            return Book.findById(book._id).exec((err, bookfound) => {
                                if (!err && bookfound) {

                                    // Update order's books' array
                                    order.books.push({
                                        _id: bookfound._id,
                                        title: bookfound.title,
                                        isbn: bookfound.isbn,
                                        quantity: book.quantity,
                                        price: bookfound.price,
                                        total: book.quantity * bookfound.price
                                    });

                                    // Update order's total cost
                                    order.total += book.quantity * bookfound.price;

                                }
                            });
                        }).then(function () {

                            // Save new Order in DB
                            order.save((err, newOrder) => {
                                if (err) {
                                    return reply(Boom.badImplementation('Server error saving order. Derp.'));
                                }
                                else {
                                    // Delete user's ID just to be safe
                                    newOrder.user._id = undefined;

                                    // Return Order object
                                    return reply(newOrder);
                                }
                            });

                        });

                    })
                    .catch((err) => {
                        return reply(Boom.unauthorized('Invalid authentication token.'));
                    });

            }
        }
    });

};