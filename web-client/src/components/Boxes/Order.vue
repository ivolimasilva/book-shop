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
                            <th>28/09/1993</th>
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
    methods: {
        toggle: function () {
            this.open = !this.open;
        }
    }
}
</script>

<style>
.box {
    margin: 15px 0px;
}

.icon {
    color: #3273dc !important;
    width: 100% !important;
    height: 100% !important;
}
</style>
