<template>
    <article class="tile is-child notification is-info">
        <div class="columns">
            <div class="column">
                <figure class="image">
                    <img class="img-small" src="https://unsplash.it/400/500">
                </figure>
            </div>
            <div class="column flex flex-column">
                <p class="title">Title</p>
                <p class="subtitle">Author</p>
                <p class="price flex-end has-text-right">10.00€</p>
            </div>
        </div>
    </article>
</template>

<script>
export default {
    name: 'item'
}
</script>

<style scoped>
.flex {
    display: flex;
}

.flex-column {
    flex-direction: column;
}

.price {
    margin-top: auto;
    font-size: 2em;
}
</style>
