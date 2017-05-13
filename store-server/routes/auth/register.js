'use strict'

var Joi = require('joi');

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
                    password: Joi.string().regex(/^[a-zA-Z0-9]{8,30}$/).required(),
                    name: Joi.string().required(),
                    address: Joi.string().required()
                }
            },
            handler: function (request, reply) {

                console.log(request.payload);

                return reply({ statusCode: 200 });
            }
        }
    });

};