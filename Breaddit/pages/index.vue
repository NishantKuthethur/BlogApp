
<template>
    <div class="main-container">
      <div class ="sub-container">
        <div class = "login-bread">
  
        </div>
        <LoginComponent v-if="isLoginPage" @successful-login="goToHomePage" @toggle-page="togglePage" />
        <RegisterComponent v-else/>
      </div>
    </div>
  </template>
  
  <script>
  import LoginComponent from '../components/Login.vue'
  import RegisterComponent from '../components/Register.vue'
  export default {
    data(){
      return{
        isLoginPage: true,
      }
      
    },
    methods: {
        togglePage() {
            this.isLoginPage = !this.isLoginPage;
        },
        goToHomePage() {
            console.log('going to home page');
            this.$router.push('/Home');
        }
    },
    components: {
      LoginComponent,
      RegisterComponent
    },
  };
  </script>
  
  <style>
  *{
    margin:0;
    padding:0;
    font-family: Montserrat;
  }
  .main-container{
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 0;
    padding: 0;
    height: 100vh;
    width: 100vw;
    background-image: url('/IndexGradient.svg') ;
    background-size: cover;
    background-repeat: no-repeat;
  }
  
  .sub-container{
      display:flex;
      /* box-shadow: 0px 0px 24px rgba(0, 0, 0, 0.12); */
      border-radius: 24px;
      overflow: hidden;
      box-shadow: 0px 0px 24px 0px rgba(0, 0, 0, 0.12);
  
  }
  
  .login-bread{
    height: 642px;
    width: 560px;
  }
  .login-bread{
    background-image: url("/HappyBread.svg");
    background-size:cover;
    background-repeat: no-repeat;
    
  }
  
  .login-container{
    height: 642px;
    width: 444px;
    padding: 64px 36px 64px 36px;
    display:flex;
    flex-flow: column;
    gap: 24px;
    align-items: center;
    justify-content: space-between;
  }
  
  @media (max-width: 1124px) {
    .login-bread {
      display: none;
    }
  }
  </style>