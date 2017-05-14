'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Promise = require('bluebird'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    Mongoose = require('mongoose'),
    Book = Mongoose.model('Book'),
    Order = Mongoose.model('Order');

module.exports = function (server) {

	/*
	 * Route for register order
	 * Method:  POST
	 * Params:  user - User making the order
	 *          books - Books of the order
	 *
	 * Returns: Error or OK, everything went fine	 */
    server.route({
        path: '/order',
        method: 'POST',
        config: {
            // Validate payload params before handler gets the load
            validate: {
                payload: {
                    user: Joi.object().required(),
                    books: Joi.array().required()
                }
            },
            handler: function (request, reply) {
                Jwt.verify(request.payload.user.token)
                    .then((jwt) => {
                        var order = new Order({
                            state: 'Waiting for dispatch', //change to integer.
                            total: 0,
                            user: {
                                id: jwt._id,
                                name: request.payload.user.name,
                                address: request.payload.user.address,
                                email: request.payload.user.email
                            },
                            books: []
                        });
                        //request.payload.books.forEach(function (book) {
                        Promise.each(request.payload.books, function (book) {
                            console.log(book);
                            Book.findById(book.id, function (err, bookfound) {
                                if (err) {
                                    console.log('Server error saving order. Derp.');
                                }
                                else if (bookfound) {
                                    console.log(bookfound);
                                    order.books.push({
                                        id: bookfound._id,
                                        title: bookfound.title,
                                        isbn: bookfound.isbn,
                                        quantity: book.quantity,
                                        price: bookfound.price,
                                        id: bookfound._id,
                                        total: book.quantity * bookfound.price
                                    });
                                    order.total += book.quantity * bookfound.price;

                                    console.log(order.books);
                                }
                                else {
                                    console.log('There is no book');
                                }
                            });
                        }).then(function () {
                            // Save new Order in DB
                            order.save((err) => {
                                if (err) {
                                    console.log(err);
                                    return reply(Boom.badImplementation('Server error saving order. Derp.'));
                                }
                                else
                                    return reply({ statusCode: 200 });
                            });
                        });

                    })
                    .catch((err) => {
                        console.log(err);
                        return reply(err);
                    });




            }
        }
    });

};