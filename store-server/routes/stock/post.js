'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    RedisSMQ = require('rsmq'),
    Promise = require('bluebird'),
    Mongoose = require('mongoose'),
    Book = Mongoose.model('Book'),
    Order = Mongoose.model('Order'),
    User = Mongoose.model('User'),
    Stock = Mongoose.model('Stock');

module.exports = function (server) {

    /*
     * Route to post stock by (optional) filter
     * Method:  POST

     * Params:  _id_order - id of the order
     *          isbn - ISBN of the book requested to the warehouse
     *          quantity - quantity of the books sent by the warehouse
     *
     * Returns:
     */

    server.route({
        path: '/stock',
        method: 'POST',
        config: {
            validate: {
                payload: {
                    stock: Joi.object().required()
                }
            },
            handler: function (request, reply) {

                var stockitem = new Stock({
                    quantity: stock.quantity,
                    isbn: stock.isbn,
                    _id_order: stock._id_order
                });
                stockitem.save((error, saved) => {
                    Order.findByIdAndUpdate(saved._id_order, {
                        status: 'Dispatch should occur at ' + new Date(new Date().getTime() + 48 * 60 * 60 * 1000)
                    }, {
                            safe: true,
                            upsert: true,
                            new: true
                        }, (err, order) => {
                            if (err) {
                                return reply(Boom.badRequest(err));
                            }
                            else {
                                return reply({
                                    statusCode: 200
                                });
                            }
                        });
                });

            }
        }
    });

};