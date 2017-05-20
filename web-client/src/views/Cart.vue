<template>
    <div>
        <!-- Header -->
        <section class="hero is-bold is-semi-white">
            <div class="hero-body">
                <div class="container">
                    <h1 class="title">
                        Shopping cart
                    </h1>
                    <h2 class="subtitle">
                        You currently have {{ cart.quantity }} items in your cart.
                    </h2>
                </div>
            </div>
        </section>
    
        <div v-if="cart.total != 0">
            <section class="container is-semi-white">
                <table class="table">
                    <thead>
                        <tr>
                            <th>ISBN</th>
                            <th>Title</th>
                            <th>Author</th>
                            <th>Quantity</th>
                            <th>Price (unitary)</th>
                            <th>Price (total)</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="item in cart.items">
                            <th>{{ item.isbn }}</th>
                            <td>{{ item.title }}</td>
                            <td>{{ item.author }}</td>
                            <td>{{ item.quantity }}</td>
                            <td>{{ item.price }}€</td>
                            <td>{{ item.quantity * item.price }}€</td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <th colspan="5">Total</th>
                            <td>
                                <strong>{{ cart.total }}€</strong>
                            </td>
                        </tr>
                    </tfoot>
                </table>
            </section>
    
            <section class="container">
                <section class="hero is-bold is-semi-white">
                    <div class="hero-body">
                        <div class="container">
                            <h1 class="title">
                                Checkout order?
                            </h1>
                            <h2 class="subtitle">
                                You currently address is
                                <strong>{{ user.address }}</strong>.
                            </h2>
                            <a class="button is-warning is-pulled-right" v-on:click="checkout">
                                Checkout
                            </a>
                        </div>
                    </div>
                </section>
            </section>
        </div>
        <checkout v-bind:is-active="active" v-bind:order="order" v-on:close="close"></checkout>
    </div>
</template>

<script>
import { mapGetters } from 'vuex';

import Checkout from '../components/Modals/Checkout.vue';

export default {
    name: 'cart',
    data: function () {
        return {
            order: {
                books: [],
                user: {
                    name: '',
                    address: '',
                    email: ''
                }
            },
            active: false
        }
    },
    computed: mapGetters([
        'user',
        'cart',
    ]),
    components: {
        'checkout': Checkout
    },
    methods: {
        checkout: function () {
            Axios.post(Server + '/order', {
                user: this.user,
                books: this.cart.items
            }, {
                    withCredentials: true
                })
                .then((response) => {
                    // Pass order to checkout
                    this.order = response.data;
                    // Add this order to Vuex
                    this.$store.commit('addOrder', response.data);
                    // Open Checkout Modal
                    this.active = true;
                    // Clear shopping cart
                    this.$store.commit('clearCart');
                })
                .catch((error) => {
                    console.log(error);
                });
        },
        close: function () {
            this.active = false;
        }
    }
}
</script>

<style scoped>
thead {
    color: black;
    background-color: #F5F5F5;
}

tfoot {
    color: black !important;
    background-color: #F5F5F5;
}
</style>
