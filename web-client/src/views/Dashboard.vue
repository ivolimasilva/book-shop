<template>
    <h1>{{ msg }}</h1>
</template>

<script>
export default {
    name: 'Dashboard',
    data: function () {
        return {
            msg: "Hello world"
        }
    },
    mounted: function () {
        console.log('Dashboard');
    }
}
</script>

<style scoped>

</style>