import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export const store = new Vuex.Store({
    state: {
        user: {
            email: '',
            name: '',
            address: '',
            token: ''
        }
    },
    mutations: {
        login(state, user) {
            // Save user's information in Store
            state.user = user;
            // Save Authentication JSON Web Token
            localStorage.setItem('token', user.token);
        }
    }
});