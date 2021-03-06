'use strict'

var validator = require('node-mongoose-validator'),
    mongoose = require('mongoose'),
    schema = new mongoose.Schema({
        status: {
            type: String,
            required: true
        },
        date: {
            type: Date,
            default: Date.now,
            required: true
        },
        total: {
            type: Number,
            required: true
        },
        user: {
            _id: {
                type: mongoose.Schema.Types.ObjectId,
                required: true
            },
            name: {
                type: String,
                required: true
            },
            address: {
                type: String,
                required: true
            },
            email: {
                type: String,
                required: true
            }
        },
        books: [
            {
                _id: {
                    type: mongoose.Schema.Types.ObjectId,
                    required: true
                },
                title: {
                    type: String,
                    required: true
                },
                isbn: {
                    type: String,
                    required: true
                },
                quantity: {
                    type: Number,
                    required: true
                },
                price: {
                    type: Number,
                    required: true
                },
                ready: {
                    type: Boolean,
                    default: false
                },
                total: {
                    type: Number,
                    required: true
                }
            }
        ]
    });

var item = mongoose.model('Order', schema);

module.exports = schema;