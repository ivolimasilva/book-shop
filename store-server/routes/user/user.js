'use strict'

var Joi = require('joi'),
    Mongoose = require('mongoose'),
    User = Mongoose.model('User'),
    Jwt = require('utils/jwt');

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
        path: '/user',
        method: 'GET',
        config: {
            // Validate payload params before handler gets the load
            validate: {
                query: {
                    token: Joi.string().required()
                }
            },
            handler: function (request, reply) {
                Jwt.verify(request.query.token)
                    .then((_id) => {
                        User.findById(_id, (err, user) => {
                            return reply({
                                email: user.email,
                                name: user.name,
                                address: user.address,
                                token: request.query.token
                            });
                        });
                    })
                    .catch((err) => {
                        return reply(err);
                    });
            }
        }
    });
};