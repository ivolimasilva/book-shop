<template>
    <div class="item">
        <a v-bind:href="uri">
            <figure class="image">
                <img class="small-margin-bottom" v-bind:src="book.imageurl">
            </figure>
            <p class="title is-5 is-bold">{{ book.title }}</p>
        </a>
        <a class="button" v-on:click="add">
            Add to cart
        </a>
        <p class="subtitle small-margin-bottom is-6">{{ book.author }}</p>
        <p class="price">{{ book.price }}€</p>
    </div>
</template>

<script>
export default {
    name: 'item',
    props: ['book'],
    computed: {
        uri: function () {
            return '/book/' + this.id;
        }
    },
    methods: {
        add: function () {
            this.$store.commit('addToCart', this.book);
        }
    }
}
</script>

<style scoped>
.item {
    width: 250px;
    height: 400px;
}

.image img {
    width: 100%;
    max-height: 300px !important;
}

.price {
    text-align: right;
    font-size: 2em;
}
</style>
