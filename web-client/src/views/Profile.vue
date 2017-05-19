<template>
    <section class="section is-fullheight">
        <div class="container">
            <h1 class="title">Details</h1>
            <div class="columns">
                <div class="column">
                    <div class="field">
                        <label class="label">Name</label>
                        <p class="control">
                            <h2 class="subtitle" v-text="user.name"></h2>
                        </p>
                    </div>
                </div>
                <div class="column">
                    <div class="field">
                        <label class="label">Email</label>
                        <p class="control">
                            <h2 class="subtitle" v-text="user.email"></h2>
                        </p>
                    </div>
                </div>
                <div class="column">
                    <div class="field">
                        <label class="label">Address</label>
                        <p class="control">
                            <h2 class="subtitle" v-text="user.address"></h2>
                        </p>
                    </div>
                </div>
            </div>
            <div class="has-text-centered">
                <a class="button is-danger" v-on:click="logout">
                    Logout
                </a>
            </div>
            <hr>
            <h1 class="title">Orders</h1>
            <div v-for="order in orders">
                <order v-bind:order="order"></order>
            </div>
        </div>
    </section>
</template>

<script>
import Order from '../components/Boxes/Order.vue';

export default {
    name: 'profile',
    components: {
        'order': Order
    },
    computed: {
        user: function () {
            return this.$store.getters.user;
        },
        orders: function () {
            return this.$store.getters.orders;
        }
    },
    mounted: function () {
        // Update orders
        this.$store.dispatch('loadOrder');
    },
    methods: {
        logout: function () {
            this.$store.commit('logout');
        }
    }
}
</script>

<style scoped>
.section {
    padding-top: 2rem !important;
}
</style>
