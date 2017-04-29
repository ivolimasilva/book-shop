'use strict'

module.exports = function (server) {

    /*
     * Route test
     */
    server.route({
        path: '/test',
        method: 'GET',
        config: {
            // Validate payload params before handler gets the load
            validate: {

            },
            handler: function (request, reply) {
                return reply({ msg: "Olá mundo" });
            }
        }
    });

};