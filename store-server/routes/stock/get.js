'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    Promise = require('bluebird'),
    Mongoose = require('mongoose'),
    Stock = Mongoose.model('Stock');

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
        path: '/stock',
        method: 'GET',
        config: {
            handler: function (request, reply) {
                Stock.find(request.query, (err, stocks) => {
                    if (err) {
                        return reply(Boom.badRequest(err));
                    } else if (stocks) {
                        if (stocks.length > 1) {
                            return reply(stocks);
                        } else {
                            return reply(stocks[0]);
                        }
                    } else {
                        return reply(Boom.badRequest('Stok not found.'));
                    }
                });
            }
        }
    });

}