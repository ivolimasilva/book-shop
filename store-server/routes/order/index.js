module.exports = function (server) {

    /*
     * Route for login
     * Method:  POST
     * Params:  email - Email of the user
     *          password - Password of the user
     *
     * Returns: the user's token to save (as cookie or localStorage idk yet)
     */
	require('routes/order/post')(server);
	require('routes/order/get')(server);
};