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
				<span class="nav-toggle">
					<span></span>
					<span></span>
					<span></span>
				</span>
				<div class="nav-right nav-menu clearfix-vertical-margins">
					<div v-if="!user.token">
						<a v-on:click="openRegister" class="nav-item is-tab is-pulled-right">Register</a>
						<a v-on:click="openLogin" class="nav-item is-tab is-pulled-right">Login</a>
					</div>
					<div v-if="user.token">
						<a v-on:click="logout" class="nav-item is-tab is-pulled-right">Logout</a>
						<a href="/cart" class="nav-item is-tab is-pulled-right">Shopping Cart ({{ cart.length }})</a>
						<a href="/profile" class="nav-item is-tab is-pulled-right">Profile ({{ user.name.split(' ')[0] }})</a>
					</div>
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
		},
		cart: function () {
			return this.$store.getters.cart;
		}
	},
	mounted: function () {
		// Check if there's a JWT
		if (this.$cookie.get('session')) {
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
		},
		logout: function () {
			this.$store.commit('logout');
		}
	}
}
</script>

<style scoped>
.clearfix-vertical-margins {
	margin-top: auto;
	margin-bottom: auto;
}

.nav-left .nav-item:first-child {
	padding-left: 0px !important;
}
</style>
