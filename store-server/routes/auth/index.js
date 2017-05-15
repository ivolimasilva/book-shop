'use strict'

module.exports = function (server) {

    /*
     * Route for login
     * Method:  POST
     * Params:  email - Email of the user
     *          password - Password of the user
     *
     * Returns: the user's token to save (as cookie or localStorage idk yet)
     */

	require('routes/auth/login')(server);

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

	require('routes/auth/register')(server);
};