// Modules
import Vue from 'vue';
import VueRouter from 'vue-router';

// Define Axios to global
window.Axios = require('axios');

// Vue modules
Vue.use(VueRouter);

// import router from './router';

import Dasboard from './views/Dashboard.vue'

const router = new VueRouter({
	mode: 'history',
	base: __dirname,
	routes: [
		{ path: '/', component: Dasboard }
	]
});

new Vue({
	router,
	el: '#app'
});