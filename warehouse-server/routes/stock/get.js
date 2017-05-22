'use strict'

var Boom = require('boom'),
    Mongoose = require('mongoose'),
    Stock = Mongoose.model('Stock');

module.exports = function (server) {

    server.route({
        path: '/stock',
        method: 'GET',
        config: {
            handler: function (request, reply) {
                Stock.find(request.query, (err, stocks) => {
                    if (err) {
                        return reply(Boom.badRequest(err));
                    } else if (stocks) {
                        return reply(stocks);
                    } else {
                        return reply(Boom.badRequest('Book not found.'));
                    }
                });
            }
        }
    });

}