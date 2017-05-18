import VueRouter from 'vue-router';

// Definition of View Routes
let routes = [
    {
        path: '/',
        component: require('./views/Dashboard.vue')
    },
    {
        path: '/book/:id',
        component: require('./views/Book.vue')
    }
];

export default new VueRouter({
    mode: 'history',
    base: __dirname,
    routes,
    linkActiveClass: 'is-active'
});