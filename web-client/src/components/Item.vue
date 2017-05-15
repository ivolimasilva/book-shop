<template>
    <div class="column is-5">
        <figure class="image">
            <img class="small-margin-bottom" v-bind:src="url">
        </figure>
        <a href="/book">
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
    ]
}
</script>

<style scoped>
img {
    display: block;
    max-height: 300px;
    max-width: 250px;
    width: auto;
    height: auto;
}

.price {
    font-size: 2em;
}
</style>
