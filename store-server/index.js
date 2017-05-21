'use strict'

var Hapi = require('hapi'),
	Config = require('config'),
	mongoose = require('mongoose'),
	Nodemailer = require('nodemailer'),
	RedisSMQ = require('rsmq'),
	rsmq = new RedisSMQ({
		host: Config.redis.host,
		port: Config.redis.port,
		ns: Config.redis.ns
	});

// Create a server with validation
var server = new Hapi.Server({
	app: {
		validation: {
			allowUnknown: true
		}
	}
});

// Configure transporter
var transporter = Nodemailer.createTransport({
	service: Config.email.service,
	auth: {
		user: Config.email.user,
		pass: Config.email.password
	}
});

// Set the port and CORS to true
server.connection({
	port: Config.server.port,
	routes: {
		cors: {
			origin: ['*'],
			// headers: ['*'],
			credentials: true
		}
	}
});

// Check if the desirable queue is created and creates it if not
rsmq.listQueues((err, queues) => {
	if (err) {
		console.error(err);
	} else {

		// Display all active queues
		console.log('Active queues: ' + queues.join(', '));

		if (queues.indexOf(Config.redis.name) < 0) {
			rsmq.createQueue({ qname: Config.redis.name }, (err, code) => {
				if (code) {
					console.log('Queue \'' + Config.redis.name + '\' created.');
				} else {
					console.log('Error creating queue with name \'' + Config.redis.name + '\'.');
				}
			});
		} else {
			console.log('Queue with name \'' + Config.redis.name + '\' already exists, using that one.');
		}

	}
});

// Use Bluebird as Promise Engine for Mongoose
mongoose.Promise = require('bluebird');

// Connect to MongoDB database
mongoose.connect(Config.database.uri);

// Load schemas
require('schemas')();

// Log (to console & file) configuration
const options = {
	ops: {
		interval: 1000
	},
	reporters: {
		console: [{
			module: 'good-squeeze',
			name: 'Squeeze',
			args: [{
				log: '*',
				response: '*'
			}]
		}, {
			module: 'good-console'
		}, 'stdout'],
		file: [{
			module: 'good-squeeze',
			name: 'Squeeze',
			args: [{
				log: '*',
				response: '*'
			}]
		}, {
			module: 'good-squeeze',
			name: 'SafeJson'
		}, {
			module: 'good-file',
			args: ['./logs/' + new Date().getTime() + '.json']
		}]
	}
};

// Routes
require('routes')(server, transporter, rsmq);

// Register and if no errors start the server
server.register({
	register: require('good'),
	options
}, (err) => {

	// Error loading the configuration
	if (err) {
		return console.error(err);
	}

	// Starting the server
	server.start(() => {
		console.info('Server started @', server.info.uri);
	});

});