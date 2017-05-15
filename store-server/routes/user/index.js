'use strict'

module.exports = function (server) {

    /*
     * Route to get user's information
     * Method:  GET
     * Params:  token - Valid token for the user
     *
     * Returns: the user's information (name, email, address)
     */

    require('routes/user/get')(server);

};