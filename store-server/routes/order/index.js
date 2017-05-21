module.exports = function (server, rsmq) {

    /*
     * Route for login
     * Method:  POST
     * Params:  email - Email of the user
     *          password - Password of the user
     *
     * Returns: the user's token to save (as cookie or localStorage idk yet)
     */
    require('routes/order/post')(server, rsmq);
    require('routes/order/get')(server);
    require('routes/order/put')(server);

};