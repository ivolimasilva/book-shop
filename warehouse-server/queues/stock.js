'use strict'

module.exports = function (worker) {

    worker.on('message', function (msg, next, id) {
        console.log("Message ID: " + id);
        console.log(msg);
        next();
    });

};