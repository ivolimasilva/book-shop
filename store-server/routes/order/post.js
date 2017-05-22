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
	 * Route for register order
	 * Method:  POST
	 * Params:  user - User who made the order
	 *          books - Ordered books
	 *
	 * Returns: Order object with ID, total, ...
     */

    server.route({
        path: '/order',
        method: 'POST',
        config: {
            validate: {
                payload: {
                    user: Joi.object().required(),
                    books: Joi.array().required()
                }
            },
            handler: function (request, reply) {

                // Message Queue Client
                var rsmq = new RedisSMQ({ client: _rsmq });

                Jwt.verify(request.payload.user.token)
                    .then((decoded) => {

                        User.findOne({
                            'email': request.payload.user.email
                        }, function (err, userx) {
                            if (err) {
                                return reply({ statusCode: 500 });
                            } else if (userx) {

                                var canBeDispatched = true;
                                // Create Order object
                                var order = new Order({
                                    status: 'Waiting for dispatch',
                                    total: 0,
                                    user: {
                                        _id: userx._id,
                                        name: request.payload.user.name,
                                        address: request.payload.user.address,
                                        email: request.payload.user.email
                                    },
                                    books: []
                                });

                                // Iterate over requested books to update order object's books
                                Promise.each(request.payload.books, function (book) {
                                    return Book.findById(book._id).exec((err, bookfound) => {

                                        if (!err && bookfound) {
                                            var ready = false;

                                            if (bookfound.stock >= book.quantity) {
                                                bookfound.stock = bookfound.stock - book.quantity;
                                                ready = true;
                                                bookfound.save();
                                            } else {
                                                
                                                var stock = new Stock({
                                                    isbn: bookfound.isbn,
                                                    _id_order: order._id,
                                                    quantity: book.quantity + 10
                                                });
                                           
                                                rsmq.sendMessage({
                                                    qname: Config.redis.name,
                                                    message: JSON.stringify(stock)
                                                }, (err, id) => {
                                                    if (id) {
                                                        console.log('Message sent: ID: ' + id);
                                                    }
                                                });
                                                stock.save();
                                          

                                                canBeDispatched = false;
                                            }

                                            // Update order's books' array
                                            order.books.push({
                                                _id: bookfound._id,
                                                title: bookfound.title,
                                                isbn: bookfound.isbn,
                                                quantity: book.quantity,
                                                price: bookfound.price,
                                                total: book.quantity * bookfound.price
                                            });

                                            // Update order's total cost
                                            order.total += book.quantity * bookfound.price;

                                        }
                                    });
                                }).then(function () {
                                    if (canBeDispatched) {
                                        var today = new Date(new Date().getTime() + 24 * 60 * 60 * 1000);
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
                                        order.status = 'Dispatched at ' + today.toLocaleDateString('pt-PT');
                                    }

                                    // Save new Order in DB
                                    order.save((err, newOrder) => {
                                        if (err) {
                                            return reply(Boom.badImplementation('Server error saving order. Derp.'));
                                        }
                                        else {
                                            var booklist = newOrder.books.reduce(function (a, item) {
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
                                                to: newOrder.user.email,
                                                subject: 'Invoices Confirmation',
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
										<h1>` + newOrder.total + `€ Paid</h1>
                                        <h2> <b>Status of order: </b>` + newOrder.status + `</h2>
                                        
									</td>
								</tr>
								<tr>
									<td class="content-block">
										<table class="invoice">
											<tr>
												<td><b>Client Name:</b> `+ newOrder.user.name + `<br>Invoice #` + newOrder._id + `<br>` + newOrder.date + `</td>
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
                                                            <strong>` + newOrder.total + `€</strong>
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
                                                text: 'Authentication code: ' + newOrder.total

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
                                            // Delete user's ID just to be safe
                                            newOrder.user._id = undefined;
                                            // Return Order object
                                            return reply(newOrder);
                                        }
                                    });

                                });


                            } else {
                                console.log("EP3");
                                return reply(Boom.badRequest('User not found.'));
                            }
                        });
                        //DECODED ENDS
                    })
                    .catch((err) => {
                        return reply(Boom.unauthorized('Invalid authentication token.'));
                    });

            }
        }
    });

};