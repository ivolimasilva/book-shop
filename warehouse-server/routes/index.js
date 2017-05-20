'use strict';

module.exports = function (server) {

	/*
	 * Routes for Book management
	 * 
	 * Routes:
	 * 	GET /book
	 */

    require('routes/book')(server);

};