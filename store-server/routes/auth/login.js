'use strict'

var Joi = require('joi');

module.exports = function (server) {

    /*
     * Route for login
     * Method:  POST
     * Params:  email - Email of the user
     *          password - Password of the user
     *
     * Returns: the user's token to save (as cookie or localStorage idk yet)
     */
    server.route({
        path: '/auth/login',
        method: 'POST',
        config: {
            // Validate payload params before handler gets the load
            validate: {
                payload: {
                    email: Joi.string().email().required(),
                    password: Joi.string().regex(/^[a-zA-Z0-9]{8,30}$/).required()
                }
            },
            handler: function (request, reply) {
                // Verify with the registred users
                return reply({ statusCode: 200 });
            }
        }
    });

};