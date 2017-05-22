'use strict'

var Mongoose = require('mongoose'),
    Stock = Mongoose.model('Stock');

module.exports = function (worker) {

    worker.on('message', function (msg, next, id) {

        var message = JSON.parse(msg),
            stock = new Stock({
                isbn: message.isbn,
                quantity: message.quantity,
                _id_order: message._id_order
            });

        stock.save((err, _stock) => {
            if (err) {
                console.log('Server error saving Stock Request.');
            } else {
                console.log('Saved Stock Request: ' + _stock._id);
            }
        });

        next();

    });

};