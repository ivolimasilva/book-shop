<template>
    <div class="modal" v-bind:class="{ 'is-active' : isActive }">
        <div class="modal-background" v-on:click="close"></div>
        <div class="modal-card">
            <header class="modal-card-head">
                <p class="modal-card-title">Login</p>
                <button class="delete" v-on:click="close"></button>
            </header>
            <section class="modal-card-body">
                <!-- Here will be a form in order to send the login information to the server -->
                <form v-on:submit.prevent="onSubmit">
                    <div class="field">
                        <p class="control has-icon">
                            <input class="input is-medium" type="email" placeholder="Email" v-model="user.email" required>
                            <span class="icon is-small">
                                <i class="fa fa-envelope"></i>
                            </span>
                        </p>
                    </div>
                    <div class="field">
                        <p class="control has-icon">
                            <input class="input is-medium" type="password" placeholder="Password" v-model="user.password" required>
                            <span class="icon is-small">
                                <i class="fa fa-key"></i>
                            </span>
                        </p>
                    </div>
                    <div class="field">
                        <p class="control">
                            <button class="button is-info is-medium is-fullwidth" type="submit">
                                Login
                            </button>
                        </p>
                    </div>
                    <span class="help has-text-centered is-danger" v-text="error"></span>
                </form>
            </section>
        </div>
    </div>
</template>

<script>
export default {
    name: 'modal-login',
    data: function () {
        return {
            user: {
                email: '',
                password: ''
            },
            error: ''
        }
    },
    props: {
        isActive: {
            type: Boolean,
            required: true
        }
    },
    methods: {
        onSubmit: function () {
            Axios.post(Server + '/auth/login', this.user)
                .then((response) => {
                    // Save user's information in Vuex Store
                    this.$store.commit('login', response.data);

                    // Clear any error message
                    this.error = '';

                    // Close Login modal
                    this.$emit('close');
                })
                .catch((error) => {
                    this.error = error.response.data.message;
                });
        },
        close: function () {
            this.$emit('close');
        }
    }
}
</script>

<style scoped>

</style>