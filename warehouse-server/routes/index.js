'use strict';

module.exports = function (server) {

	/*
	 * Routes for Book management
	 * 
	 * Routes:
	 * 	GET /book
	 */

	require('routes/book')(server);

	/*
	 * Routes for Stock Requests
	 * 
	 * Routes:
	 * 	GET /stock
	 */

	require('routes/stock')(server);

};