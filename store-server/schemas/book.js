'use strict'

var validator = require('node-mongoose-validator'),
    mongoose = require('mongoose'),
    schema = new mongoose.Schema({
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
            
        },
        year: {
            type: Number,
            required: true
        },
        publisher: {
            type: String,
            required: true
        },
        imageurl:{
            type: String
        },
        price:{
            type: Number
        },
        stock: {
            type: Number,
            required: true
        }
    });

var item = mongoose.model('Book', schema);

module.exports = schema;