'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
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

                Order.find({}, (err, orders) => {
                    return reply(orders);
                });

            }
        }
    });

};