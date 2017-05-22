'use strict'

module.exports = function (server, transporter, rsmq) {

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

    /*
     * Route to update stock and dispatch order if possible
     * Method:  POST

     * Params:  
     *
     * Returns:
     */
    require('routes/stock/put')(server, transporter, rsmq);
    /*
     * Route to get stock
     * Method:  GET
     * Params:  _id?order - order of id
     *          quantity - quantity of order
     *          accepted - if clerk has acceped package
     *          (doesn't work with queries other than equal, like 'less than' (<), 'greater than' (>), ...)
     *          (no filter returns all the books)
     *
     * Returns: the stock's information*/
    require('routes/stock/get')(server);
};