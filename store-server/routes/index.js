module.exports = function (server) {
	/*
	 * Routes for authentication
	 * Auth routes have the '/auth' prefix
	 * 
	 * Routes:
	 * 	/login
	 *  /register
	 */
	require('routes/auth')(server);

	/*
	 * Routes for authentication
	 * Auth routes have the '/auth' prefix
	 * 
	 * Routes:
	 * 	/login
	 *  /register
	 */
	require('routes/user')(server);
};