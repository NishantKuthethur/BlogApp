
import { Login } from '#build/components';

import { Login } from '#build/components';

import { Login } from '#build/components';

import { Login } from '#build/components';
<template>
    <div class = "Register-container">
        <div v-if="!isOtpPage" class="Register-form">
            <p>Register</p>
            <form class="Register-form-controls">
                <div class="control">
                    <label for="username">Name</label>
                    <input type="text" placeholder="Enter your Password" class="name-icon">
                </div>
                <div class="control">
                    <label for="username">Email</label>
                    <input type="text" placeholder="Enter your Password" class="username-icon">
                </div>
                <div class="control">
                    <label for="username">Username</label>
                    <input type="text" placeholder="Enter your Username" class="username-icon">
                </div>
                <div class="control">
                    <label for="username">Password</label>
                    <input type="password" placeholder="Enter your Password" class="password-icon">
                </div>
            </form>
            <button @click="toggleOtpPage" type="submit" class="submit-button"><p>Register</p></button>
        </div>
        <div v-else class="otp-form">
            <!-- Your OTP entering part here -->
            <h1>Register</h1>
            <form class="otp-form-controls">
                <p>Enter the 6 digit code sent to your email</p>
                <div class="otp-control">
                    <input v-for="(otp, index) in otpArray" :key="index" :ref="'otpInput' + index" type="number" :value="otp" @input="handleOtpInput(index, $event)" @keydown="handleKeyDown(index, $event)" maxlength="1" class="otp-input"/>
                </div>
            </form>
            <button @click="toggleOtpPage" type="submit" class="submit-button"><p>Continue</p></button>
        </div>
    </div>
</template>
<script>
export default {
  
  data() {
    return {
      username: '',
      password: '',
      name: '',
      email: '',
      response: '',
      isOtpPage: false,
      otpArray: ['', '', '', '', '', '']
    };
  },

  methods: {
    toggleOtpPage() {
      this.isOtpPage = !this.isOtpPage;
      console.log(this.isOtpPage);
    },
    handleOtpInput(index, event) {
      const value = event.target.value;

      // Ensure the value is a digit between 0 and 9
      if (/^[0-9]$/.test(value)) {
        this.otpArray[index] = value;

        // Focus the next input box
        if (index < this.otpArray.length - 1) {
          this.$refs['otpInput' + (index + 1)][0].focus();
        }
      } else {
        // Reset the value if it's not a digit
        event.target.value = this.otpArray[index] = '';
      }
    },
    handleKeyDown(index, event) {
      if (event.key === 'Backspace' && !this.otpArray[index]) {
        // Focus the previous input box
        if (index > 0) {
          this.$refs['otpInput' + (index - 1)][0].focus();
          this.otpArray[index - 1] = ''; // Clear the value of the previous box
        }
      }
    },
  }
};
</script>
<style scoped>
:root {
  --primary-color: rgba(0, 96, 96, 1);
  --font-family: Montserrat;
}

*{
  font-family: Montserrat;
}
.Register-container{
  height: 642px;
  width: 444px;
}
.Register-container{
  padding: 64px 36px 64px 36px;
  display:flex;
  flex-flow: column;
  gap: 24px;
  align-items: center;
}

.Register-form{
  display: flex;
  flex-flow: column;
  align-items: center;
  gap: 24px; 
  width: 372px;
  height: 504.74px;
}

.Register-form p{
  display: flex;
  flex-flow: column;
  align-items: center;
  font-size: 44px;
  font-weight: 600;
  height: 44px;
  width: 450px;
}


/*Register area controls */

.Register-form-controls{
  display:flex;
  flex-flow:column;
  align-items: start;
  width: 372px;
  height: 364.74px;
  gap: 24px;
}

.control{
  width:100%;
  height: 73.14px;
}

.control label{
  font-size: 14px;
  font-weight: 700;
  line-height: 17px;
  letter-spacing: 0.20000000298023224px;
  text-align: left;
}

.control input{
  width: 100%;
  padding: 10px 16px;
  border-radius: 8px;
  border: 1px;
  /* justify: space-between; */
  border: 1px solid rgba(0, 96, 96, 1);
  transition: box-shadow 0.3s ease;
}

.control input:focus, .control input:hover{
  
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

.name-icon{
  background-image: url('../static/accessibility.svg'); /* Replace 'your-icon.svg' with the actual SVG file name */
  background-repeat: no-repeat;
  background-position: right 10px center; /* Adjust the position as needed */
  background-size: 20px; /* Adjust the size as needed */
  padding-right: 40px; /* Make room for the icon */
}

.submit-button{
  display: flex;
  width: 372px; /* Adjust as needed */
  height: 48px; /* Adjust as needed */
  padding: 10px 16px; /* Increase padding */
  border-radius: 4px;
  background-color: rgba(0, 96, 96, 1);
  
}

.submit-button p{
  font-size: 18px; /* Reduce font size */
  font-weight: 600;
  letter-spacing: 0.2px;
  text-align: center; /* Center the text */
  color: rgba(255, 255, 255, 1);
}

/* otp form controls */
.otp-form{
    display:flex;
    flex-flow: column;
    align-items: center;
    width: 372px;
    height:auto;
    gap: 24px;
}
.otp-form h1{
  display: flex;
  flex-flow: column;
  align-items: center;
  font-size: 44px;
  font-weight: 600;
  height: 44px;
  width: 450px;
}
.otp-form-controls{
    display:flex;
    flex-flow: column;
    width: 372px;
    height: 73.95px;
    gap: 8px;
}

.otp-form-controls p{
  width: 304px;
  height: 17px;
  rotate: 0.18deg;
  font-size: 14px;
  font-weight: 700;
  line-height: 17px;
  letter-spacing: 0.20000000298023224px;
  text-align: left;
  text-wrap: nowrap;
}
.otp-control{
    display: flex;
    justify-content: space-between;
    flex-flow: row;
}
.otp-control input{
    width: 48px;
    height: 48px;
    padding: 10px 16px 10px 16px;
    border-radius: 4px;
    border: 1px;
    justify: space-between;
}
.otp-form button {
    display: flex;
    flex-flow: column;
    align-items: center;
    width: 372px;
    height:48px;
    padding: 10px 16px 10px 16px;
    border-radius: 4px;
}
.otp-form button p{
font-size: 16px;
font-weight: 600;
line-height: 20px;
letter-spacing: 0.20000000298023224px;
text-align: left;

}
</style>