<template>
    <div class="container">
        <p class="title is-1">Recent</p>
        <div class="columns is-multiline">
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
            <item class="item"></item>
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
        Axios.get(Server + '/book')
            .then((books) => {
                this.books = books;
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
    width: 250px;
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