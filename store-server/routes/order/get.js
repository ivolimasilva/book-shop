'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    Promise = require('bluebird'),
    Mongoose = require('mongoose'),
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
        method: 'GET',
        config: {
            handler: function (request, reply) {

                // Verify if token is valid and returns user's ID
                Jwt.verify(request.state.session)
                    .then((decoded) => {
                        Order.find({ 'user._id': new Mongoose.Types.ObjectId(decoded._id) }, (err, orders) => {
                            return reply(orders);
                        });

                    })
                    .catch((err) => {
                        return reply(Boom.unauthorized('Invalid token.'));
                    });
            }
        }
    });

};