<template>
  <div :class="$style.inlog">

    <div :class="$style.frame1">
      <img :class="$style.frameIcon" alt="" src="/frame.svg" />
      <div :class="$style.frame2">
        <div :class="$style.frame3">
          <a
            :class="$style.vanRijtAutomatisering"
            href="http://"
            target="_blank"
            >van Rijt automatisering © 2023</a
          >
        </div>
        <div :class="$style.frame4" id="LoginForm">
          <div :class="$style.loginParent">
            <div :class="$style.login">Login</div>
            <div :class="$style.email">Email</div>
            <div :class="$style.wachtwoord">Wachtwoord</div>

            <!-- <button :class="$style.inloggenWrapper" id="Submit" @click="sendLoginDataToApi">
              <div :class="$style.inloggen">Inloggen</div>
            </button> -->

                <button :class="$style.inloggenWrapper" id="Submit" @click="sendLoginDataToApi">
                  <div :class="$style.inloggen">Inloggen</div>
                </button>
            
              <v-text-field
                :class="$style.frameVtextfield"
                color="primary"
                variant="outlined"
                type="email"
                name="Email"
                v-model="email" 
              />

            <div :class="$style.frame5">
              <button :class="$style.wijzigWachtwoord" id="ChangePassword">
                wijzig wachtwoord
              </button>
              <v-text-field
                :class="$style.frameVtextfield1"
                color="primary"
                variant="outlined"
                :append-inner-icon="showPasswordGm ? 'mdi-eye' : 'mdi-eye-off'"
                v-model="passwordGm"
                :type="showPasswordGm ? 'text' : 'password'"
                @click:appendInner="togglePasswordVisibilityGm"
                name="Password"
              />
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import axios from 'axios';
import { defineComponent } from "vue";

export default defineComponent({
  name: "Inlog",
  data() {
    return {
      email: '',       // Data property to store the email value
      passwordGm: '',  // Data property to store the password value
      showPasswordGm: false,
    };
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
});
</script>

<style lang="scss" module>

.frame {
  position: absolute;
  top: 2.88rem;
  left: 2.81rem;
  width: 8.94rem;
  height: 64.06rem;
  overflow: hidden;
}
.frameIcon {
  position: relative;
  width: 51rem;
  height: 70.06rem;
  overflow: hidden;
  flex-shrink: 0;
}
.vanRijtAutomatisering {
  position: absolute;
  top: 67.19rem;
  left: 0rem;
  text-decoration: underline;
  font-weight: 800;
  color: inherit;
}
.frame3 {
  position: absolute;
  top: 0rem;
  left: 24.63rem;
  width: 14.38rem;
  height: 68.44rem;
  overflow: hidden;
}
.login {
  position: absolute;
  top: 4rem;
  left: 3rem;
  font-size: 2.75rem;
  font-weight: 600;
}
.email {
  position: absolute;
  top: 10rem;
  left: 3rem;
  font-weight: 500;
}
.wachtwoord {
  position: absolute;
  top: 20rem;
  left: 3rem;
  font-weight: 500;
}
.inloggenWrapper {
  cursor: pointer;
  border: 1px solid rgba(255, 255, 255, 0.8);
  padding: 0.63rem;
  background-color: var(--primary);
  position: absolute;
  top: 34rem;
  left: 14rem;
  border-radius: 16px;
  box-sizing: border-box;
  width: 14.81rem;
  overflow: hidden;
  display: flex;
  flex-direction: row;
  align-items: flex-start;
  justify-content: center;
.inloggen {
    $white: #ffffff;
    position: relative;
    font-size: var(--font-size-7xl);
    font-weight: 500;
    font-family: var(--font-inter);
    color: $white;
    text-align: left;
  }
}
.frameVtextfield {
  width: 26rem;
  border: none;
  background-color: transparent;
  position: absolute;
  top: 13rem;
  left: 3rem;
}

.wijzigWachtwoord {
  cursor: pointer;
  border: none;
  padding: 0;
  background-color: transparent;
  position: absolute;
  top: 3.63rem;
  left: 16rem;
  font-size: var(--font-size-mini);
  font-weight: 800;
  font-family: var(--font-manrope);
  color: var(--color-darkgray);
  text-align: center;
  display: inline-block;
  width: 9.25rem;
  height: 1.25rem;
}

.frameVtextfield1 {
  width: 26rem;
  border: none;
  background-color: transparent;
  position: absolute;
  top: 0rem;
  left: 0rem;
}
.frame5 {
  position: absolute;
  top: 23rem;
  left: 3rem;
  width: 27.41rem;
  height: 4.88rem;
  overflow: hidden;
}
.loginParent {
  position: absolute;
  top: 0.06rem;
  left: 0rem;
  border-radius: 56px;
  background-color: var(--color-white);
  box-shadow: var(--dropshadow);
  width: 33.13rem;
  height: 40rem;
}
.frame4 {
  position: absolute;
  top: 8rem;
  left: 5rem;
  width: 33.13rem;
  height: 46.06rem;
  overflow: hidden;
  font-size: var(--font-size-7xl);
  color: var(--color-black);
  font-family: var(--font-inter);
}
.frame2 {
  position: relative;
  width: 39rem;
  height: 60.44rem;
  overflow: hidden;
  flex-shrink: 0;
  margin-left: -2.87rem;
}
.frame1 {
  position: absolute;
  top: -0.12rem;
  left: -20rem;
  width: 105rem;
  height: 50.06rem;
  overflow: hidden;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: flex-end;
  text-align: center;
  font-size: var(--font-size-mini);
  color: var(--color-darkgray);
  font-family: var(--font-manrope);
}
.inlog {
  position: relative;
  background-color: #eef1f6;
  width: 100%;
  height: 100vh;
  overflow: hidden;
  text-align: left;
  font-size: 2.81rem;
  color: #049fb4;
  font-family: var(--font-inter);
}
</style>
