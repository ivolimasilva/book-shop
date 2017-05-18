<template>
    <div class="item">
        <a v-bind:href="uri">
            <figure class="image">
                <img class="small-margin-bottom" v-bind:src="url">
            </figure>
            <p class="title is-5 is-bold">{{ title }}</p>
        </a>
        <p class="subtitle small-margin-bottom is-6">{{ author }}</p>
        <p class="price">{{ price }}€</p>
    </div>
</template>

<script>
export default {
    name: 'item',
    props: [
        'id',
        'title',
        'author',
        'price',
        'url'
    ],
    computed: {
        uri: function () {
            return '/book/' + this.id;
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
