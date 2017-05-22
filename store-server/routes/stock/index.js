'use strict'

module.exports = function (server) {

    /*
     * Route to post stock by (optional) filter
     * Method:  POST

     * Params:  _id_order - id of the order
     *          isbn - ISBN of the book requested to the warehouse
     *          quantity - quantity of the books sent by the warehouse
     *
     * Returns:
     */

    require('routes/stock/post')(server);

};