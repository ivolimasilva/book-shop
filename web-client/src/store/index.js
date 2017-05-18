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
    getters: {
        user: (state) => {
            return state.user;
        }
    },
    mutations: {
        login(state, user) {
            // Save user's information in Store
            state.user = user;
            // Save Authentication JSON Web Token
            localStorage.setItem('token', user.token);
        }
    },
    actions: {
        loadUser(context) {
            Axios.get(Server + '/user', {
                params: {
                    token: localStorage.getItem('token')
                }
            })
                .then((response) => {
                    context.commit('login', response.data);
                })
                .catch((error) => {
                    console.log(error);
                });
        }
    }
});