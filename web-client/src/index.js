// Modules
import Vue from 'vue';
import VueRouter from 'vue-router';
import VueCookie from 'vue-cookie';

// Define global variables
window.Axios = require('axios');
window.Server = 'http://localhost:9000';

// Vue modules
Vue.use(VueRouter);
Vue.use(VueCookie);
import router from './router';
import { store } from './store';

// Components
import Navbar from './components/Navbar.vue';

new Vue({
	router,
	store,
	el: '#app',
	components: {
		'navbar': Navbar
	}
});