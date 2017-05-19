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
        },
        orders: []
    },
    getters: {
        user: (state) => {
            return state.user;
        },
        orders: (state) => {
            return state.orders;
        }
    },
    mutations: {
        login(state, user) {
            // Save user's information in Store
            state.user = user;

            // Save Authentication JSON Web Token
            Vue.cookie.set('session', user.token, {
                expires: '1Y',
                domain: 'localhost'
            });
        },
        order(state, orders) {
            state.orders = orders;
        }
    },
    actions: {
        // TODO: Refactor errors
        // TODO: GET doesn't need params, since session works with cookie now
        loadUser(context) {
            Axios.get(Server + '/user', {
                params: {
                    token: Vue.cookie.get('session')
                }
            })
                .then((response) => {
                    context.commit('login', response.data);
                })
                .catch((error) => {
                    console.log(error);
                });
        },
        loadOrder(context) {
            Axios.get(Server + '/order')
                .then((response) => {
                    context.commit('order', response.data);
                })
                .catch((error) => {
                    console.log(error);
                });
        }
    }
});