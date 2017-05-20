<template>
    <div class="modal" v-bind:class="{ 'is-active' : isActive }">
        <div class="modal-background" v-on:click="close"></div>
        <div class="modal-card">
            <header class="modal-card-head">
                <p class="modal-card-title">Order confirmed</p>
                <button class="delete" v-on:click="close"></button>
            </header>
            <section class="modal-card-body">
                <div class="columns">
                    <div class="column">
                        <div class="field">
                            <label class="label">Name</label>
                            <p class="control">
                                {{ order.user.name }}
                            </p>
                        </div>
                    </div>
                    <div class="column">
                        <div class="field">
                            <label class="label">Email</label>
                            <p class="control">
                                {{ order.user.email }}
                            </p>
                        </div>
                    </div>
                    <div class="column">
                        <div class="field">
                            <label class="label">Address</label>
                            <p class="control">
                                {{ order.user.address }}
                            </p>
                        </div>
                    </div>
                </div>
                <hr>
                <table class="table is-narrow is-striped">
                    <thead>
                        <tr>
                            <th>Title</th>
                            <th>Quantity</th>
                            <th>Price (unit)</th>
                            <th>Price (total)</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="book in order.books">
                            <td>{{ book.title }}</td>
                            <td>{{ book.quantity }}</td>
                            <td>{{ book.price }}€</td>
                            <td>{{ book.quantity * book.price }}€</td>
                        </tr>
                    </tbody>
                </table>
                <hr>
                <div class="columns">
                    <div class="column">
                        <div class="field">
                            <label class="label">Status</label>
                            <p class="control">
                                {{ order.status }}
                            </p>
                        </div>
                    </div>
                    <div class="column is-1">
                        <div class="field">
                            <label class="label">Total</label>
                            <p class="control">
                                <strong>{{ order.total }}€</strong>
                            </p>
                        </div>
                    </div>
                </div>
            </section>
            <footer class="modal-card-foot">
                <a class="button" disabled>Print</a>
                <a class="button" v-on:click="close">Close</a>
            </footer>
        </div>
    </div>
</template>

<script>
export default {
    name: 'checkout',
    props: ['isActive', 'order'],
    methods: {
        close: function () {
            this.$emit('close');
        }
    }
}
</script>

<style scoped>
@media screen and (min-width: 769px) {
    .modal-card,
    .modal-content {
        margin: 0 auto;
        max-height: calc(100vh - 40px);
        width: 900px;
    }
}
</style>