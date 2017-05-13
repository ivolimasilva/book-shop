<template>
    <div class="modal" v-bind:class="{ 'is-active' : isActive }">
        <div class="modal-background" v-on:click="close"></div>
        <div class="modal-card">
            <header class="modal-card-head">
                <p class="modal-card-title">Register</p>
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
                        <p class="control has-icon">
                            <input class="input is-medium" type="text" placeholder="Name" v-model="user.name" required>
                            <span class="icon is-small">
                                <i class="fa fa-user"></i>
                            </span>
                        </p>
                    </div>
                    <div class="field">
                        <p class="control has-icon">
                            <input class="input is-medium" type="text" placeholder="Address" v-model="user.address" required>
                            <span class="icon is-small">
                                <i class="fa fa-address-card"></i>
                            </span>
                        </p>
                    </div>
                    <div class="field">
                        <p class="control">
                            <button class="button is-info is-medium is-fullwidth" type="submit">
                                Register
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
    name: 'modal-register',
    data: function() {
        return {
            user: {
                name: '',
                email: '',
                password: '',
                address: ''
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
            onSubmit: function() {
                Axios.post('http://localhost:9000/auth/register', this.user)
                    .then(function(response) {
                        console.log('Registo ok.');
                    })
                    .catch(function(err) {
                        console.log(err);
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