'use strict';

module.exports = function (server, transporter, rsmq) {

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

	require('routes/order')(server, transporter, rsmq);

	/*
	 * Routes for user information
	 * 
	 * Routes:
	 * 	GET /user
	 */

	require('routes/user')(server);

	/*
	 * Routes for stock information
	 * 
	 * Routes:
	 * 	POST /stock
	 */

	require('routes/stock')(server);
};