<<template>
	<section class="hero is-info is-bold">
		<nav class="nav">
			<div class="container">
				<div class="nav-left">
					<a class="nav-item" href="/">
						<h1 class="title">
							Book Shop
						</h1>
					</a>
				</div>
				<div class="nav-right clearfix-vertical-margins">
					<div v-if="user == {}">
						<a v-on:click="openRegister" class="nav-item is-pulled-right">Register</a>
						<a v-on:click="openLogin" class="nav-item is-pulled-right">Login</a>
					</div>
					<div v-if="user != {}">
						<a href="/profile" class="nav-item is-pulled-right">{{ user.name }}</a>
					</div>
					<a class="nav-item is-pulled-right" target="_blank" href="https://github.com/ivolimasilva/book-shop">
						<span class="icon">
							<i class="fa fa-github"></i>
						</span>
					</a>
				</div>
			</div>
		</nav>
		<modal-login v-bind:is-active="activeLogin" v-on:close="closeLogin"></modal-login>
		<modal-register v-bind:is-active="activeRegister" v-on:close="closeRegister"></modal-register>
	</section>
</template>

<script>
import ModalLogin from './Modals/Login.vue';
import ModalRegister from './Modals/Register.vue';

export default {
	name: 'navbar',
	components: {
		'modal-login': ModalLogin,
		'modal-register': ModalRegister
	},
	data: function () {
		return {
			activeLogin: false,
			activeRegister: false
		}
	},
	computed: {
		user: function () {
			return this.$store.getters.user;
		}
	},
	mounted: function () {
		// Check if there's a JWT
		if (localStorage.getItem('token')) {
			// If so, load user
			this.$store.dispatch('loadUser');
		}
	},
	methods: {
		openLogin: function () {
			this.activeLogin = true;
		},
		closeLogin: function () {
			this.activeLogin = false;
		},
		openRegister: function () {
			this.activeRegister = true;
		},
		closeRegister: function () {
			this.activeRegister = false;
		}
	}
}
</script>

<style scoped>
.clearfix-vertical-margins {
	margin-top: auto;
	margin-bottom: auto;
}
</style>
