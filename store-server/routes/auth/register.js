'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Bcrypt = require('bcrypt'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    Mongoose = require('mongoose'),
    User = Mongoose.model('User');

module.exports = function (server) {

	/*
	 * Route for register
	 * Method:  POST
	 * Params:  email - Email of the user
	 *          password - Password of the user
	 * 			Name - Name of the user
	 * 			Address - Full address of the user
	 *
	 * Returns: the user's token to save (as cookie or localStorage idk yet)
	 */
    server.route({
        path: '/auth/register',
        method: 'POST',
        config: {
            // Validate payload params before handler gets the load
            validate: {
                payload: {
                    email: Joi.string().email().required(),
                    password: Joi.string().regex(/^[a-zA-Z0-9]{3,30}$/).required(),
                    name: Joi.string().required(),
                    address: Joi.string().required()
                }
            },
            handler: function (request, reply) {

                // Encrypts the password field
                Bcrypt.hash(request.payload.password, Config.saltRounds)
                    .then((hash) => {

                        // Create a new User object
                        var user = new User({
                            name: request.payload.name,
                            email: request.payload.email,
                            password: hash,
                            address: request.payload.address
                        });

                        // Save new User in DB
                        user.save((err, _user) => {
                            if (err) {
                                return reply(Boom.badImplementation('Server error saving user.'));
                            } else {
                                // Encode token
                                Jwt.encode({ _id: _user._id })
                                    .then((_token) => {
                                        return reply({
                                            email: _user.email,
                                            name: _user.name,
                                            address: _user.address,
                                            token: _token
                                        });
                                    })
                                    .catch((err) => {
                                        return reply(Boom.badImplementation('Server error generating token.'));
                                    });
                            }
                        });
                    });
            }
        }
    });

};