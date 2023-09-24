<template>
    <div class="login-card">
        <b-card>
            <b-form @submit.prevent="login">
                <b-form-group label="Username">
                    <b-form-input type="text" v-model="username"></b-form-input>
                </b-form-group>
                <b-form-group label="Password">
                    <b-form-input type="password" v-model="password"></b-form-input>
                </b-form-group>
                <b-button class="formButton" type="submit" variant="primary">Login</b-button>
                <p v-text="response"></p>
            </b-form>
        </b-card>
    </div>
</template>
<script>
export default {

  data() {
    return {
      username: '',
      password: '',
      response:''
    };
  },

  methods: {
    async login() {

      try { 

        const response = await this.$axios.post('User/Login', {
          Username: this.username,
          Password: this.password
        }, {
            headers: {
                'Content-Type': 'application/json'
            }
        });

        // Handle success
        this.response = response.data;
        console.log('User logged in', response.data);

      } 
      catch (error) {
        
        if (error.response && error.response.status === 400) {
            // Handle 400 error
            this.response = "Invalid login credentials";
            console.log("Invalid login credentials");
        } 
        else 
        {
            // Handle other errors
            this.response = error;
            console.log('An error occurred while logging in:', error);
            
        }
      }
    
    }
  }
};
</script>

<style>

.login-card{
    display:flex;
    width: 100vw;
    height: 100vh;
    justify-content: center;
    align-items:center;
}

.formButton{
    margin: auto;
    display: block;
}

</style>