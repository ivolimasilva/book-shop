<template>
    <div class="column is-5">
        <figure class="image">
            <img class="small-margin-bottom" src="https://unsplash.it/400/500">
        </figure>
        <p class="title is-5 is-bold">A Sociedade dos Sonhadores Involuntários</p>
        <p class="subtitle small-margin-bottom is-6">José Eduardo Agualusa</p>
        <p class="price">10.00€</p>
    </div>
</template>

<script>
export default {
    name: 'item',
    props: [
        'title',
        'author',
        'price'
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
