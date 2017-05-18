<template>
    <div class="container">
        <h1 class="title" v-text="book.title"></h1>
        <h1 class="title" v-text="book.author"></h1>
        <h1 class="title" v-text="book.isbn"></h1>
        <h1 class="title" v-text="book.publisher"></h1>
        <h1 class="title" v-text="book.year"></h1>
        <h1 class="title" v-text="book.price"></h1>
        <h1 class="title" v-text="book.stock"></h1>
    </div>
</template>

<script>
export default {
    name: 'book',
    data: function () {
        return {
            book: {}
        }
    },
    mounted: function () {
        var self = this;

        Axios.get(Server + '/book', {
            params: {
                _id: self.$route.params.id
            }
        })
            .then((response) => {
                console.log(response);
                self.book = response.data;
            })
            .catch((error) => {
                console.log(error);
            });
    }
}
</script>

<style>

</style>
