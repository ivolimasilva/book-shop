import VueRouter from 'vue-router';

// Definition of View Routes
let routes = [
    {
        name: 'home',
        path: '/',
        component: require('./views/Dashboard.vue')
    },
    {
        name: 'book',
        path: '/book/:id',
        component: require('./views/Book.vue')
    },
    {
        name: 'profile',
        path: '/profile/',
        component: require('./views/Profile.vue')
    },
    {
        name: 'cart',
        path: '/cart/',
        component: require('./views/Cart.vue')
    }
];

export default new VueRouter({
    mode: 'history',
    base: __dirname,
    routes,
    linkActiveClass: 'is-active'
});