'use strict'

var Joi = require('joi');

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
                return reply({
                    email: request.payload.email,
                    name: 'Ivo Lima da Silva',
                    address: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.',
                    token: '123456789'
                });
            }
        }
    });

};