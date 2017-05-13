'use strict'

var Joi = require('joi'),
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

                User.findOne({
                    email: request.payload.email,
                    password: request.payload.password
                }, function (err, user) {

                    if (err) {
                        return reply({ statusCode: 500 });
                    } else {
                        return reply({
                            email: user.email,
                            name: user.name,
                            address: user.address,
                            token: '123456789'
                        });
                    }

                });
            }
        }
    });

};