'use strict'

var validator = require('node-mongoose-validator'),
    mongoose = require('mongoose'),
    schema = new mongoose.Schema({
        name: {
            type: String,
            required: true
        },
        email: {
            type: String,
            required: true,
            unique: true
        },
        password: {
            type: String,
            required: true
        },
        address: {
            type: String,
            required: true
        },
        employee: {
            type: Number,
            default: 0
        }
    });

var item = mongoose.model('User', schema);

module.exports = schema;