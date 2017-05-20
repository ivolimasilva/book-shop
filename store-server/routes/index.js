'use strict';

module.exports = function (server, transporter) {

	/*
	 * Routes for authentication
	 * Auth routes have the '/auth' prefix
	 * 
	 * Routes:
	 * 	POST /auth/login
	 * 	POST /auth/register
	 */

	require('routes/auth')(server);

	/*
	 * Routes for Book management
	 * 
	 * Routes:
	 * 	GET /book
	 */

	require('routes/book')(server);

	/*
	 * Routes for Orders management
	 * 
	 * Routes:
	 * 	POST /order
	 */

	require('routes/order')(server, transporter);

	/*
	 * Routes for user information
	 * 
	 * Routes:
	 * 	GET /user
	 */

	require('routes/user')(server);

};