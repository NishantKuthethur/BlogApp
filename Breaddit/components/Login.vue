<template>
    <div class = "login-container">
        <div class="login-form">
            <p>Login to Breaddit</p>
            <div class="login-form-controls">
              <div class="username-control">
                <label for="username">Username</label>
                <input type="text" placeholder="Enter your Username" class="username-icon">
              </div>
              <div class="password-control">
                <label for="username">Password</label>
                <input type="password" placeholder="Enter your Password" class="password-icon">
              </div>
            </div>
            <div class="login-redirect-controls">
              <button type="submit" class="submit-button">Login</button>
              <div class="login-password-controls">
                <a href="#" class="teal-font forgot-password">Forgot Password?</a>
                <div class="remember-me" >
                  
                  <label for="RememberMe" class="teal-font remember-me-label">
                    <input id="RememberMe"  v-model="isChecked" type="checkbox" class="remember-me-checkbox">
                    
                    <span class="checkmark"></span>Remember Me
                  </label>
                </div>
              </div>
            </div>
        </div>
        <a href="#" @click="togglePage" class="register-redirect">Don’t have an account yet? Register</a>
    </div>
</template>

<script>
export default {

data() {
  return {
    username: '',
    password: '',
    response:'',
    isChecked: false,
  };
},

methods: {
  async login() {

    try {

      // const response = await this.$axios.post('User/Login', {
      //   Username: this.username,
      //   Password: this.password
      // }, {
      //     headers: {
      //         'Content-Type': 'application/json'
      //     }
      // });

      // // Handle success
      // this.response = response.data;
      // console.log('User logged in', response.data);
        this.$emit('successful-login');
    }
    catch (error) {

      // if (error.response && error.response.status === 400) {
      //     // Handle 400 error
      //     this.response = "Invalid login credentials";
      //     console.log("Invalid login credentials");
      // }
      // else
      // {
      //     // Handle other errors
      //     this.response = error;
      //     console.log('An error occurred while logging in:', error);

      // }
    }

  },
    toggleCheckbox() {
        this.isChecked = !this.isChecked;
    },
    togglePage() {
        this.$emit('toggle-page');
    }
}
};
</script>

<style scoped>


.login-form{
    display: flex;
    flex-flow: column;
    align-items: center;
    justify-content:center;
    /* margin-top: 64px;
    margin-bottom: 24px;
    margin-left: 36px;
    margin-right: 36px; */
    gap: 24px;
    width: Fill(372px);
    height: 342.47px;
    gap: 24px;
}

.login-form p{
font-size: 36px;
font-weight: 600;
line-height: 44px;
letter-spacing: 0.20000000298023224px;
text-align: center;

  height: 44px;
  width: 341px;
}

.register-redirect{
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
  width: 254px;
  height: 62px;
  color: rgba(0, 96, 96, 1);; 
}

/*login area controls */
.login-form-controls{
  display:flex;
  flex-flow:column;
  align-items: flex-start;
  width: 100%;
  gap: 24px;
}

.username-control,.password-control{
  width:100%;
}

.username-control label,.password-control label{
  width: 77px;
  height:17px;
  padding: 8px;
  font-size: 14px;
  font-weight: 700;
  line-height: 17px;
  letter-spacing: 0.20000000298023224px;
  text-align: left;
}

.username-control input,.password-control input{
  width: 100%;
  padding: 10px 16px;
  border-radius: 8px;
  border: 1px;
  /* justify: space-between; */
  border: 1px solid rgba(0, 96, 96, 1);
  transition: box-shadow 0.3s ease;
}

.username-control input:focus, .password-control input:focus, .username-control input:hover, .password-control input:hover {
  
  /* justify: space-between; */
  box-shadow: inset 0 0 0 3px rgba(0, 96, 96, 1);
  outline: none;
}

.username-icon{
  background-image: url('../static/perm_identity.svg'); /* Replace 'your-icon.svg' with the actual SVG file name */
  background-repeat: no-repeat;
  background-position: right 10px center; /* Adjust the position as needed */
  background-size: 20px; /* Adjust the size as needed */
  padding-right: 40px; /* Make room for the icon */
}

.password-icon{
  background-image: url('../static/vpn_key.svg'); /* Replace 'your-icon.svg' with the actual SVG file name */
  background-repeat: no-repeat;
  background-position: right 10px center; /* Adjust the position as needed */
  background-size: 20px; /* Adjust the size as needed */
  padding-right: 40px; /* Make room for the icon */
}

.login-redirect-controls{
  display:flex;
  flex-flow: column;
  justify-content: space-between;
  width: 100%;
  gap: 12px;
}

.submit-button{
  display: flex;
  justify-content: center; /* Center the text horizontally */
  align-items: center; /* Center the text vertically */
  width: 100%; /* Adjust as needed */
  height: 48px; /* Adjust as needed */
  padding: 16px 16px; /* Increase padding */
  border-radius: 4px;
  background-color: rgba(0, 96, 96, 1);
  font-family: Montserrat;
  font-size: 18px; /* Reduce font size */
  font-weight: 600;
  letter-spacing: 0.2px;
  text-align: center; /* Center the text */
  color: rgba(255, 255, 255, 1);
}

.teal-font{
  color: rgba(0, 96, 96, 1);
}

.login-password-controls{
  display: flex;
  flex-flow:row;
  justify-content: space-between;
  height:20px;
  width:100%;
}

.forgot-password{
  font-size: 14px;
  font-weight: 500;
  line-height: 17px;
  letter-spacing: 0.20000000298023224px;
  text-align: left;
}

.remember-me{
  display:flex;
  gap:4px;
  font-size: 14px;
  font-weight: 500;
  line-height: 17px;
  letter-spacing: 0.20000000298023224px;
  text-align: left;
}

.remember-me-label{
  display:flex;
  height: 17px;
  font-size: 14px;
  font-weight: 500;
  line-height: 17px;
  letter-spacing: 0.20000000298023224px;
  text-align: left;
  gap:4px;
  justify-content: center;
  align-items: center;
  position: relative;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  
}

.remember-me input{
  opacity: 0;
  cursor: pointer;
  height: 0;
  width: 0;
}
.checkmark{
  height: 20px;
  width: 20px;
  background-color: #fff;
  border: 1px solid rgba(0, 96, 96, 1);
  border-radius: 2px;
  transition: box-shadow 0.3s ease;
}

.remember-me-label:hover input ~ .checkmark {
  box-shadow: inset 0 0 0 2px rgba(0, 96, 96, 1);
}

.remember-me-label input:checked ~ .checkmark {
  background-color: rgba(0, 96, 96, 1);
}

.checkmark:after {
  content: "";
  position: absolute;
  display: none;
}

.remember-me-label input:checked ~ .checkmark:after {
  display: block;
}

/* Style the checkmark/indicator */
.remember-me-label .checkmark:after {
  left: 11px;
  top: 3px;
  width: 5px;
  height: 10px;
  border: solid white;
  border-width: 0 3px 3px 0;
  -webkit-transform: rotate(45deg);
  -ms-transform: rotate(45deg);
  transform: rotate(45deg);
}

</style>