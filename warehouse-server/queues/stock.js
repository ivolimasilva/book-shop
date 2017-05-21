'use strict'

var RedisSMQ = require("rsmq"),
    rsmq = new RedisSMQ({
        host: "127.0.0.1",
        port: 6379,
        ns: "rsmq"
    });

module.exports = function () {

    rsmq.receiveMessage({ qname: "myqueue" }, (err, resp) => {
        if (resp.id) {
            console.log("Message received.", resp);
        }
        else {
            console.log("No messages for me...");
        }
    });

}