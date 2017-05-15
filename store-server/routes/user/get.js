'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Jwt = require('utils/jwt'),
    Mongoose = require('mongoose'),
    User = Mongoose.model('User');

module.exports = function (server) {

    /*
     * Route to get user's information
     * Method:  GET
     * Params:  token - Valid token for the user
     *
     * Returns: the user's information (name, email, address)
     */

    server.route({
        path: '/user',
        method: 'GET',
        config: {
            validate: {
                query: {
                    token: Joi.string().required()
                }
            },
            handler: function (request, reply) {

                // Verify if token is valid and returns user's ID
                Jwt.verify(request.query.token)
                    .then((decoded) => {

                        // Search DB for the user by ID
                        User.findById(decoded._id, (err, user) => {

                            if (err) {
                                return reply(Boom.badRequest(err));
                            } else if (user) {
                                // Return user's information
                                return reply({
                                    email: user.email,
                                    name: user.name,
                                    address: user.address,
                                    token: request.query.token
                                });
                            } else {
                                return reply(Boom.badRequest('User not found.'));
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