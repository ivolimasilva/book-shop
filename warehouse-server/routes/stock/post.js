'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Axios = require('axios'),
    Mongoose = require('mongoose'),
    Stock = Mongoose.model('Stock');

module.exports = function (server) {

    server.route({
        path: '/stock',
        method: 'POST',
        config: {
            validate: {
                payload: {
                    _id: Joi.required()
                }
            },
            handler: function (request, reply) {
                console.log(request.payload);
                Stock.findById(request.payload._id, (err, _stock) => {

                    Axios.post('http://localhost:9000' + '/stock', {
                        _id_order: _stock._id_order,
                        isbn: _stock.isbn,
                        quantity: _stock.quantity
                    })
                        .then((response) => {
                            return reply();
                        })
                        .catch((error) => {
                            return reply(error);
                        });

                });

            }
        }
    });

};