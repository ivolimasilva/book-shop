'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Jwt = require('utils/jwt'),
    Bcrypt = require('bcrypt'),
    Mongoose = require('mongoose'),
    User = Mongoose.model('User');

module.exports = function (server) {

    /*
     * Route for login
     * Method:  POST
     * Params:  email - Email of the user
     *          password - Password of the user
     *
     * Returns: the user's info + token to save (as cookie or localStorage idk yet)
     */
    server.route({
        path: '/auth/login',
        method: 'POST',
        config: {
            // Validate payload params before handler gets the load
            validate: {
                payload: {
                    email: Joi.string().email().required(),
                    password: Joi.string().regex(/^[a-zA-Z0-9]{3,30}$/).required()
                }
            },
            handler: function (request, reply) {

                console.log(request.payload);
                User.findOne({
                    email: request.payload.email
                }, function (err, user) {

                    if (err) {
                        return reply({ statusCode: 500 });
                    } else if (user) {

                        Bcrypt.compare(request.payload.password, user.password)
                            .then((res) => {
                                if (res) {
                                    // Encode token
                                    Jwt.encode({ _id: user._id })
                                        .then((_token) => {
                                            return reply({
                                                email: user.email,
                                                name: user.name,
                                                address: user.address,
                                                token: _token
                                            }).header('Access-Control-Allow-Credentials', true);
                                        })
                                        .catch((err) => {
                                            return reply(Boom.badImplementation('Server error generating token.'));
                                        });
                                } else {
                                    // Wrong password
                                    return reply(Boom.unauthorized('Incorrect password.'));
                                }
                            });

                    } else {
                        console.log("EP3");
                        return reply(Boom.badRequest('User not found.'));
                    }

                });
            }
        }
    });

};