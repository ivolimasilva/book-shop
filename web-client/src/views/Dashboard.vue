<template>
    <div class="container">
        <div class="tile is-ancestor">
            <div class="tile is-parent is-8">
                <article class="tile is-child notification is-info">
                    <div class="columns">
                        <div class="column">
                            <figure class="image">
                                <img class="img-big" src="https://unsplash.it/300/500">
                            </figure>
                        </div>
                        <div class="column flex flex-column">
                            <a>
                                <p class="title">Title</p>
                            </a>
                            <p class="subtitle">Author</p>
                            <p class="price flex-end has-text-right">10.00€</p>
                        </div>
                    </div>
                </article>
            </div>
            <div class="tile is-vertical">
                <div class="tile">
                    <div class="tile is-parent is-vertical">
                        <item></item>
                        <item></item>
                        <item></item>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import Item from '../components/Item.vue';

export default {
    name: 'Dashboard',
    components: {
        'item': Item
    }
}
</script>

<style scoped>
.container {
    margin-top: 25px;
}

.flex {
    display: flex;
}

.flex-column {
    flex-direction: column;
}

.summary {
    text-align: justify;
}
</style>