<template>
    <div class="box">
        <div class="columns">
            <div class="column">
                <table class="table">
                    <thead>
                        <tr>
                            <th>Date</th>
                            <th>Address</th>
                            <th>Total</th>
                            <th>Status</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th>{{ date }}</th>
                            <td>{{ order.user.address }}</td>
                            <td>{{ order.total }}€</td>
                            <td>{{ order.state }}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
            <div class="column is-1">
                <a v-on:click="toggle">
                    <span class="icon">
                        <i v-if="!open" class="fa fa-plus-circle"></i>
                        <i v-if="open" class="fa fa-minus-circle"></i>
                    </span>
                </a>
            </div>
        </div>
        <section class="section" v-if="open">
            <h1 class="title">Ordered Books</h1>
            <table class="table">
                <thead>
                    <tr>
                        <th>ISBN</th>
                        <th>Title</th>
                        <th>Quantity</th>
                        <th>Price (unitary)</th>
                        <th>Price (total)</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="book in order.books">
                        <th>{{ book.isbn }}</th>
                        <td>{{ book.title }}</td>
                        <td>{{ book.quantity }}</td>
                        <td>{{ book.price }}€</td>
                        <td>{{ book.total }}€</td>
                    </tr>
                </tbody>
            </table>
        </section>
    </div>
</template>

<script>
export default {
    name: 'order',
    props: ['order'],
    data: function () {
        return {
            open: false
        }
    },
    computed: {
        date: function () {
            return new Date(this.order.date).toLocaleDateString();
        }
    },
    methods: {
        toggle: function () {
            this.open = !this.open;
        }
    }
}
</script>

<style scoped>
.box {
    margin: 15px 0px;
}

.box .columns {
    margin-bottom: 0px;
}

.box .section {
    padding-top: 0px;
    padding-bottom: 0px;
}

.icon {
    color: #3273dc !important;
    width: 100% !important;
    height: 100% !important;
}
</style>
