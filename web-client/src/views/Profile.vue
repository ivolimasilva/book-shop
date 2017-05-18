<template>
    <div>
        <div>
            <p>{{ user.name }}</p>
            <p>{{ user.email }}</p>
            <p>{{ user.address }}</p>
        </div>
        <div v-for="order in orders" v-cloak>
            <p>{{ order.state }}</p>
            <p>{{ order.total }}€</p>
            <div v-for="book in order.books">
                <p>{{ book.title }}</p>
                <p>{{ book.isbn }}</p>
                <p>{{ book.quantity }}</p>
                <p>{{ book.price }}</p>
                <p>{{ book.total }}</p>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'profile',
    computed: {
        user: function () {
            return this.$store.getters.user;
        },
        orders: function () {
            return this.$store.getters.orders;
        }
    },
    beforeMount: function () {
        // Update orders
        this.$store.dispatch('loadOrder');
    }
}
</script>

<style>

</style>
