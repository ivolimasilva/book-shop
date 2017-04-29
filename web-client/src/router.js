import VueRouter from 'vue-router';

// Definition of View Routes
let routes = [
    {
        path: '/',
        component: require('./views/Dashboard.vue')
    }
];

export default new VueRouter({
    mode: 'history',
    base: __dirname,
    routes,
    linkActiveClass: 'is-active'
});