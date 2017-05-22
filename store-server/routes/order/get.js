'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    Promise = require('bluebird'),
    Mongoose = require('mongoose'),
    User = Mongoose.model('User'),
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
                var please = null;
                // Verify if token is valid and returns user's ID
                Jwt.verify(request.state.session)
                    .then((decoded) => {
                        User.findById(decoded._id, function (err, loggeduser) {
                            if (loggeduser) {
                                if (loggeduser.security_level > 0) {
                                    Order.find({}, (err, orders) => {
                                        return reply(orders);
                                    });
                                } else {
                                    // Finds all orders associated with logged in User 
                                    Order.find({ 'user.email': loggeduser.email }, (err, orders) => {
                                        return reply(orders);
                                    });
                                }
                            }
                        });
                    })
                    .catch((err) => {
                        return reply(Boom.unauthorized('Invalid token.'));
                    });
            }
        }
    });

};