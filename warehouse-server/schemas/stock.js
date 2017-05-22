'use strict'

var Mongoose = require('mongoose'),
    schema = new Mongoose.Schema({
        isbn: {
            type: String,
            required: true,
            unique: true
        },
        _id_order: {
            type: String
        },
        quantity: {
            type: Number,
            required: true
        }
    });

var item = Mongoose.model('Stock', schema);

module.exports = schema;