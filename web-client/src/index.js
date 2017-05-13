// Modules
import Vue from 'vue';
import VueRouter from 'vue-router';

// Define Axios to global
window.Axios = require('axios');

// Vue modules
Vue.use(VueRouter);
import router from './router';

// Components
import Navbar from './components/Navbar.vue';

new Vue({
	router,
	el: '#app',
	components: {
		'navbar': Navbar
	}
});