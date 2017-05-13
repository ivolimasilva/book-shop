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
        }
    },
    actions: {
        login({ commit }, user) {
            // Call mutations to change state
            commit('login', user);
            return new Promise(resolve => {
                localStorage.setItem('token', user.token);
                resolve();
            });
        }
    }
});