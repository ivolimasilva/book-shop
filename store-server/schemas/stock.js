'use strict'

var Mongoose = require('mongoose'),
    schema = new Mongoose.Schema({
        isbn: {
            type: String,
            required: true,
            unique: true
        },
        _id_order: {
            type: String,
            required: true
        },
        quantity: {
            type: Number,
            required: true
        },
        replied: {
            type: Boolean,
            default: false
        }
    });

var item = Mongoose.model('Stock', schema);

module.exports = schema;