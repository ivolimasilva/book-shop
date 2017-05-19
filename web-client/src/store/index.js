import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

// TODO: Refactor with modules
export const store = new Vuex.Store({
    state: {
        user: {
            email: '',
            name: '',
            address: '',
            token: ''
        },
        orders: [],
        cart: {
            total: 0,
            quantity: 0,
            items: []
        }
    },
    getters: {
        user: (state) => {
            return state.user;
        },
        orders: (state) => {
            return state.orders;
        },
        cart: (state) => {
            return state.cart;
        }
    },
    mutations: {
        login(state, user) {
            // Save user's information in Store
            state.user = user;

            // Save Authentication JSON Web Token
            Vue.cookie.set('session', user.token, {
                expires: '1Y'
            });
        },
        logout(state) {
            // Clear cookie
            Vue.cookie.delete('session');

            // Clear user
            state.user = {
                email: '',
                name: '',
                address: '',
                token: ''
            };

            // Clear orders
            state.orders = [];

            // Clear cart
            state.cart = [];
        },
        order(state, orders) {
            state.orders = orders;
        },
        addToCart(state, book) {
            // Increment quantity
            state.cart.quantity++;

            // Increment total
            state.cart.total += book.price;

            if (state.cart.items.indexOf(book) > -1) {
                state.cart.items[state.cart.items.indexOf(book)].quantity++;
            } else {
                book.quantity = 1;
                state.cart.items.push(book);
            }
        }
    },
    actions: {
        // TODO: Refactor errors
        loadUser(context) {
            Axios.get(Server + '/user', {
                withCredentials: true
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