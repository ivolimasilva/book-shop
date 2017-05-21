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
	 * Route for change order status
	 * Method:  PUT
	 * Params:  order._id - status Object id 
	 *          status - status intended
	 *
	 * Returns: change successful ...
     */

    server.route({
        path: '/order/{id}',
        method: 'PUT',
        config: {
            description: 'Update specific order status',
            notes: 'Update specific user data',
            validate: {
                params: {
                    //`id` is required field and can only accept string data
                    id: Joi.string().required()
                },
                payload: {
                    status: Joi.string().required()
                }
            },
            handler: function (request, reply) {

                console.log(request.params.id);
                Order.findByIdAndUpdate(request.params.id, request.payload, {
                    safe: true,
                    upsert: true,
                    new: true
                }, function (error, data) {
                    if (error) {
                        reply({
                            statusCode: 503,
                            message: 'Failed to get data',
                            data: error
                        });
                    } else {
                        console.log(data);
                        reply({
                            statusCode: 200,
                            message: 'Order Updated Successfully',
                            data: data
                        });
                    }
                });
            }
        }
    });

};