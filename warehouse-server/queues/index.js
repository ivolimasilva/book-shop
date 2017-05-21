'use strict';

var Config = require('config'),
    RedisSMQ = require('rsmq'),
    rsmq = new RedisSMQ({
        host: Config.redis.host,
        port: Config.redis.port,
        ns: Config.redis.ns
    }),
    RSMQWorker = require("rsmq-worker"),
    worker = new RSMQWorker(Config.redis.name, {
        rsmq: rsmq,
        autostart: true
    });

module.exports = function () {

    require('message-queues/stock')(worker);

};