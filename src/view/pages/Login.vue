<template>
  <div class="login">
    <div class="content">
      <div class="formWrapper">
        <form @submit.prevent="submitForm">
          <h1>Inloggen</h1>
          <div>
            <label for="email">Emailadres</label>
            <input type="email" name='Email' placeholder="gebruikersnaam@domein.nl" v-model="email" required>
          </div>
          <div>
            <label for="password">Wachtwoord</label>
            <input type="password" name="Password" placeholder="********" v-model="passwordGm" required>

          </div>
          <button type="submit" @click="sendLoginDataToApi">Inloggen</button>
          <a href="">Ik ben mijn wachtwoord vergeten</a>
        </form>
      </div>
    </div>
    <ImageFrame></ImageFrame>
  </div>
</template>
<script>
import ImageFrame from "../../viewmodel/components/imageFrame.vue";
import imageFrame from "../../viewmodel/components/imageFrame.vue";
import { defineComponent, ref } from "vue";
import axios from 'axios';


export default defineComponent({
  name: "Login",

  data() {
    return {
      email: '',       // Data property to store the email value
      passwordGm: '',  // Data property to store the password value
      showPasswordGm: false,

    //  { showPasswordGm: false, passwordGm: "" }
    };
  },
    data() {
    return { showPasswordGm: false, passwordGm: "" };
  },
  methods: {
    sendLoginDataToApi() {
      // Define the API URL
      const apiUrl = 'https://localhost:7129/api/Login';

      // Define the data to send in the request body using the captured values
      const requestBody = {
        EMail: this.email,        // Use the email data property
        Password: this.passwordGm, // Use the passwordGm data property
      };

      // Define the headers you want to send with the request
      const headers = {
        'Content-Type': 'application/json', // Replace with the appropriate content type
      };

      // Send a POST request to the API with headers and the request body
      axios.post(apiUrl, requestBody, { headers })
        .then((response) => {
          // Handle the response data here
          console.log(response.data);
        })
        .catch((error) => {
          // Handle any errors here
          console.error(error);
        });


    },
             togglePasswordVisibilityGm() {
          this.showPasswordGm = !this.showPasswordGm;
          },
  },

  components: { ImageFrame }
})

</script>
<style lang="scss">
@import '../scss/root.scss';
@import '../scss/login.scss';
</style>
