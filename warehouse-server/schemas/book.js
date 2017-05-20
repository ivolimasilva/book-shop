'use strict'

var Mongoose = require('mongoose'),
    schema = new Mongoose.Schema({
        isbn: {
            type: String,
            required: true,
            unique: true
        },
        title: {
            type: String,
            required: true
        },
        author: {
            type: String,
            required: true
        },
        year: {
            type: Number,
            required: true
        },
        publisher: {
            type: String,
            required: true
        },
        image: {
            type: String
        },
        price: {
            type: Number
        },
        stock: {
            type: Number,
            required: true
        }
    });

var item = Mongoose.model('Book', schema);

module.exports = schema;