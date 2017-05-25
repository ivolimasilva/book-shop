# Distribution and Integration Technologies (TDIN)

## Assignment #2 - An enterprise distributed system

### Team

* [Daniel Nunes](https://github.com/PNDaniel)
* [Ivo Lima da Silva](https://github.com/ivolimasilva)
* [Sara Linhas Paiva](https://github.com/Linhas)

### Project specification: [link](https://github.com/ivolimasilva/book-shop/blob/master/specification.md).

### Overview

The purpose of this work is to develop a system for coordinating the sales, orders and stock management of a book editor, while following the Service Oriented Architecture (SOA) principles. As such, a building block can play any of three roles, the service provider, the service registry and the server requester. The customers are capable of doing an order via a web app or in the store. In the case there is no sufficient stock in the book store the system asks for more items to the warehouse. The warehouse server does not need to be always on but it has to guarantee the requests done to it while offline are satisfied. 

### Architecture Specification

For this project implementation it was decided that the servers were developed in Node.js and the web client using the Vue.js framework, that follows a structure MVVM, to build the user interface. The database uses MongoDB as Database engine.

The final result was a two server structure that when the warehouse server was down, it still received messages through Message Queues using REDIS as a Message Broker to implement processing of background jobs or other kinds of messaging tasks. In figure 1. it is possible to see how the system was constructed and communication is issued.

![](http://i.imgur.com/br2FdHt.png)

### Schema

Each server has their own structure of data being that there are some similarities. The warehouse needs both the book list and the stock request in order to be able to answer the bookstore needs. The Book schema was filled with an actual database of 1000 exemplars, including their cover image. The list of all schemas and parameters is as follows, with additional information on some particular terms:

* Book - saves all information related to the books in the inventory;
  * Isbn
  * Title
  * Author
  * Year
  * Publisher
  * Image
  * Price
  * Stock 
* Order - saves all information related to the orders of the service:
  * Status
  * Date
  * Total
  * User
    * _id
    * Name
    * Address
    * Email
  * Book
    * _id
    * Title
    * Isbn
    * Quantity
    * Price
    * Ready (type boolean that informs whether all books with this isbn from this order are already reserved for dispatch)  
    * Total
* Stock - saves all information about stock requests:
  * ISBN
  * _id_order
  * Quantity
  * Accepted (type boolean, default false - that is only present in the store-server; it state is changed to true when the “clerk” in the store receives the stock from the warehouse)
* User - saves all information related to the registered users of the service
  * Name
  * Email
  * Password
  * Address
  * Security_Level (indicates the permissions of a user; default is like a normal user, security_level = 0)

### Routes

In table 1 it is possible to view the different routes included for this system implementation, divided by the two servers.

![](http://i.imgur.com/DbOrsj0.png)

### Functionalities

It was possible to implement all the functionalities requested for this project, the full list can be viewed in table below. The flow of a general interaction with our system can be viewed in figure 2. All functionalities were tested.

| Functionality | Warehouse | Bookshop | Web |
| --- | --- | --- | --- |
| Register new user | | | ✓ |
| Login/Logout users | | ✓ | ✓ |
| Check available stock | | ✓ | ✓ |
| Check the price of a book | | ✓ | ✓ |
| Make order for one book | | ✓ | ✓ |
| Make order for several types of books at the same time | | ✓ | ✓ |
| As store clerk make orders for another user | | ✓ | |
| Offline communication by Message Queues to receive restock requests | ✓ | | |
| Change status of order | | ✓ | |
| Dispatch order only after all books are ready | | ✓ | |
| As a normal user, see own orders | | | ✓ |
| As a store clerk, see all orders | | ✓ | ✓ |
| Send email with order information after sell is made | | ✓ | ✓ |
| Send email when order status changes from “Waiting for dispatch” to “Dispatched at...” | | ✓ | ✓ |
| Emit invoices | | ✓ | |
| Information persistence | ✓ | ✓ | |
| Restock books according to request from store | ✓ | | |
| Print a receipt | | ✓ | |

![](http://i.imgur.com/D8it2Fj.png)

### Future Work

* Include a super user capable of changing registered users security_level.
* Have a search function in the web-client.
* Request stock from the store to the warehouse when a clerk desires

### Instructions to Install and Run

#### Installation

* Dependencies
    * Install NodeJS
    * Install MongoDB
    * Install Redis
        * In Windows, it’s advised to install through Chocolatey
        * In addition to that, run the following command in Administrator Shell: npm install --global --production windows-build-tools
    * After downloading the project, run npm install to download the specific dependencies of each application (folders store-server, warehouse-server and web-client)
* Configuration
    * In order to run store-server and warehouse-server it’s needed to have a file name default.json in a folder named config in each of the servers’ root
    * This file must have the following structure:
        * store-server’s and warehouse-server’s configuration file, respectively:
```
{
   "server": {
       "port": 9000
   },
   "redis": {
       "host": <YOUR REDIS SERVER>, // normally 127.0.01
       "Port": <YOUR REDIS PORT>, // normally 6379
       "ns": "rsmq",
       "name": "stock-requests"
   },
   "database": {
       "uri": "mongodb://localhost:27017/store"
   },
   "secret": <YOUR SECRET PASS-PHRASE TO ENCRYPT PASSWORDS>,
   "saltRounds": <NUMBER OF SALT ROUNDS TO ENCRYPT PASSWORDS>,
   "email": {
       "service": <YOUR E-MAIL SERVICE>, // like "Gmail", ...
       "user": <YOUR E-MAIL TO SEND THE INVOICES>,
       "password": <YOUR E-MAIL PASSWORD>
   }
}
```

```
{
   "server": {
       "port": 9090
   },
   "database": {
       "uri": "mongodb://localhost:27017/warehouse"
   },
   "redis": {
       "host": <YOUR REDIS SERVER>, // normally 127.0.01
       "Port": <YOUR REDIS PORT>, // normally 6379
       "ns": "rsmq",
       "name": "stock-requests"
   },
}

```

#### Run

* To run store-server or warehouse-server just run npm start in each folder (each terminal must be left open)
* To run web-client, in its folder run npm run dev. This will automatically open the web-client in your default browser
* To run each GUI application, you can run through the bin folder or open the project in Visual Studio