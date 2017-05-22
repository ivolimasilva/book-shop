'use strict'

var Mongoose = require('mongoose'),
    Stock = Mongoose.model('Stock');

module.exports = function (worker) {

    worker.on('message', function (msg, next, id) {

        var stock = new Stock(JSON.parse(msg.message));

        stock.save((err, _stock) => {
            if (err) {
                console.log('Server error saving Stock Request.');
            } else {
                console.log('Saved Stock Request.');
            }
        });

        next();

    });

};