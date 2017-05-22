'use strict'

var Joi = require('joi'),
    Boom = require('boom'),
    Config = require('config'),
    Jwt = require('utils/jwt'),
    RedisSMQ = require('rsmq'),
    Promise = require('bluebird'),
    Mongoose = require('mongoose'),
    Book = Mongoose.model('Book'),
    Order = Mongoose.model('Order'),
    User = Mongoose.model('User'),
    Stock = Mongoose.model('Stock'),
    inLineCss = require('nodemailer-juice');

module.exports = function (server, transporter, _rsmq) {


    /*
     * Route to update stock and dispatch order if possible
     * Method:  POST

     * Params:  
     *
     * Returns:
     */

    server.route({
        path: '/stock',
        method: 'PUT',
        config: {
            validate: {
                payload: {
                    _id: Joi.required()
                }
            },
            handler: function (request, reply) {
                // Message Queue Client
                var rsmq = new RedisSMQ({ client: _rsmq });
                var canBeDispatched = true;

                //Finds the stock in the requests stocks
                Stock.findById(request.payload._id, (err, _stock) => {
                    _stock.accepted = true;
                    _stock.save();

                    Book.findOne({ 'isbn': _stock.isbn }).exec(function (err, bookfound) {
                        Book.findById(bookfound._id).exec((err, _book) => {
                            if (err) {
                                console.log(err);
                            } else if (_book) {
                                _book.stock = _stock.quantity + bookfound.stock;
                                _book.save();
                            } else {
                                console.log('No book found');
                            }
                        });

                        //finds the order in our order list
                        Order.findById(_stock._id_order, (err, _order) => {

                            Promise.each(_order.books, (bookorder) => {
                                return new Promise((resolve, reject) => {
                                    if (bookorder.isbn == _stock.isbn) {
                                        resolve(bookorder);
                                    }
                                });
                            }).then((bookorder) => {
                                if (!bookorder[0].ready) {

                                    Book.findById(bookorder[0]._id, (err, bookStock) => {
                                        if (bookStock.stock > bookorder[0].quantity) {
                                            bookStock.stock -= bookorder[0].quantity;
                                            bookStock.save();

                                            Order.findById(_order._id, (err, ordered) => {
                                                Promise.each(ordered.books, (bookek) => {
                                                    return new Promise((resolve, reject) => {
                                                        if (bookek.isbn == bookStock.isbn) {
                                                            bookek.ready = true;
                                                            ordered.save();
                                                            console.log('Order ready and saved.');
                                                        }
                                                    });
                                                });
                                            });
                                        } else {
                                            var stock = new Stock({
                                                isbn: bookStock.isbn,
                                                _id_order: _order._id,
                                                quantity: bookorder.quantity + 10
                                            });

                                            rsmq.sendMessage({
                                                qname: Config.redis.name,
                                                message: JSON.stringify(stock)
                                            }, (err, id) => {
                                                if (id) {
                                                    console.log('Message sent: ID: ' + id);
                                                }
                                            });
                                        }
                                    });
                                }
                            });


                            //go through whole order and  if all ready canBeDispatched = true;
                            //send email saying that 
                            //save new order status

                            Promise.each(_order.books, function (book) {
                                return new Promise(function (resolve, reject) {
                                    if (!book.ready) {
                                        canBeDispatched = false;
                                    }

                                    resolve();
                                });
                            }).then(function () {
                                if (canBeDispatched) {
                                    var today = new Date(new Date().getTime());
                                    /*   var dd = today.getDate();
                                       var mm = today.getMonth() + 1;
                                       var yyyy = today.getFullYear();
 
                                       if (dd < 10) {
                                           dd = '0' + dd
                                       }
 
                                       if (mm < 10) {
                                           mm = '0' + mm
                                       }
 
                                       today = dd + '/' + mm + '/' + yyyy;*/
                                    _order.status = 'Dispatched at ' + today.toLocaleDateString('pt-PT');
                                    _order.save();

                                    console.log('Final do ReadyVerify');
                                }
                                var booklist = _order.books.reduce(function (a, item) {
                                    return a + `<tr>
                                                        <th>`+ item.isbn + `</th>
                                                        <td>`+ item.title + `</td>
                                                        <td>`+ item.quantity + `</td>
                                                        <td>`+ item.price + `€</td>
                                                        <td>`+ item.quantity * item.price + `€</td>
                                                    </tr>`;
                                }, '');

                                // Email configuration
                                var mailOptions = {
                                    from: 'Ye Old Book Shop',
                                    to: _order.user.email,
                                    subject: 'Thy package is on its way',
                                    html:
                                    `
                                        <table class="body-wrap">
                                            <tr>
                                                <td></td>
                                                <td class="container" width="600">
                                                    <div class="content">
                                                        <table class="main" width="100%" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td class="content-wrap aligncenter">
                                                                    <table width="100%" cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                            <td class="content-block">
                                                                                <h1>` + _order.total + `€ Paid</h1>
                                                                                <h2> <b>Status of order: </b>` + _order.status + `</h2>
                                                                                
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="content-block">
                                                                                <table class="invoice">
                                                                                    <tr>
                                                                                        <td><b>Client Name:</b> `+ _order.user.name + `<br>Invoice #` + _order._id + `<br>` + _order.date + `</td>
                                                                                    </tr>
                                                                                    <tr>
                                                                                        <td>

                                                                                <table class="table">
                                                                                        <thead>
                                                                                            <tr>
                                                                                                <th>ISBN</th>
                                                                                                <th>Title</th>
                                                                                                <th>Quantity</th>
                                                                                                <th>Price (unitary)</th>
                                                                                                <th>Price (total)</th>
                                                                                            </tr>
                                                                                        </thead>
                                                                                        <tbody>
                                                                                        ` + booklist + `
                                                                                        </tbody>
                                                                                        <tfoot>
                                                                                            <tr>
                                                                                                <th colspan="5">Total</th>
                                                                                                <td>
                                                                                                    <strong>` + _order.total + `€</strong>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </tfoot>
                                                                                    </table> 
                                                                                    </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <br>
                                                                            <br>
                                                                            <td class="content-block">
                                                                                <a style="    background-color: #4CAF50; /* Green */
                                                                                                border: none;
                                                                                                color: white;
                                                                                                padding: 15px 32px;
                                                                                                text-align: center;
                                                                                                text-decoration: none;
                                                                                                display: inline-block;
                                                                                                font-size: 16px;" href="http://localhost:8080/profile">Check You Order!</a>
                                                                        </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="content-block">
                                                                                <h2>Thanketh thee for using Ye Old Book Shop inc.</h2>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td class="content-block">
                                                                                Rua das Carmelitas, 144 4050-161 Porto Portugal.
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                        <div class="footer">
                                                            
                                                        </div></div>
                                                </td>
                                                <td></td>
                                            </tr>
                                        </table>

                                        </body>

                                            `,
                                    text: 'Authentication code: ' + _order.total

                                };


                                transporter.use('compile', inLineCss());
                                // Send code by email
                                transporter.sendMail(mailOptions, (err, info) => {
                                    if (err) {
                                        //return reply(Boom.badImplementation('Error sending email with authentication code.'));
                                    } else {
                                        // Return status OK
                                        //return reply({ statusCode: 200 });
                                    }
                                });
                            })

                            if (err) {
                                return reply(Boom.badRequest(err));
                            }
                            else {
                                return reply();
                            }
                        });
                    });
                });
            }
        }
    });
};