<template>
    <div class="container">
        <p class="title is-1">Recent</p>
        <div class="columns is-multiline">
            <div v-for="book in books">
                <item class="column is-5 item" v-bind:book="book"></item>
            </div>
        </div>
    </div>
</template>

<script>
import Item from '../components/Item.vue';

export default {
    name: 'Dashboard',
    data: function () {
        return {
            books: []
        }
    },
    components: {
        'item': Item
    },
    mounted: function () {
        Axios.get(Server + '/book', {
            params: {
                year: 2001
            }
        })
            .then((response) => {
                this.books = response.data;
            });
    }
}
</script>

<style scoped>
.container {
    margin-top: 25px;
    padding-right: 1em;
}

.item {
    width: 200px;
    margin-left: auto;
    margin-right: auto;
}

.columns .item:nth-child(5n+1) {
    margin-left: 0;
}

.columns .item:nth-child(5n) {
    margin-right: 0;
}
</style>