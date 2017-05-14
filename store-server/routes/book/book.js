'use strict'

var Joi = require('joi'),
    Mongoose = require('mongoose'),
    Book = Mongoose.model('Book');

module.exports = function (server) {
    /*
    * Route for a request of a single Book
    * Method: GET
    * Params: id
    *
    * Returns: A single books information with it's ID
    */
    server.route({
        path: '/book/{id}',
        method: 'GET',
        config: {
            // Validate payload params before handler gets the load
            handler: function (request, reply) {
                Book.findById(request.params.id, (err, book) => {
                    return reply(book);
                })
            }
        }
    });
    /*
    * Route for a request of All Books 
    * Method: GET
    * Params: none
    *
    * Returns: all books
    */
    server.route({
        path: '/books',
        method: 'GET',
        config: {
            // Validate payload params before handler gets the load
            handler: function (request, reply) {
                Book.find({}, (err, book) => {
                    return reply(book);
                })
            }
        }
    });
}
