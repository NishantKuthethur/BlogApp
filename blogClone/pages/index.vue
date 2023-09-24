<template>
  <LoginComponent/>
</template>

<script lang="ts">
import Vue from 'vue'
import LoginComponent from '../components/Login.vue'
export default Vue.extend({
  name: 'IndexPage',
  components:{
    LoginComponent
  }
})
</script>
