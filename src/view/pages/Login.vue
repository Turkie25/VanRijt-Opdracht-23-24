<template>
  <div class="login">
    <div class="content">
      <div class="formWrapper">
        <form @submit.prevent="submitForm">
          <h1>Inloggen</h1>
          <div>
            <label for="email">Emailadres</label>
            <input type="email" placeholder="gebruikersnaam@domein.nl" v-model="email" required>
          </div>
          <div>
            <label for="password">Wachtwoord</label>
            <input type="password" placeholder="********" v-model="password" required>
          </div>
          <button type="submit" @click="sendLoginDataToApi">Inloggen</button>
          <span>Geen inloggevens? <a href="">Meer informatie</a></span>
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

export default defineComponent({
  name: "Login",
  data() {
    return { showPasswordGm: false, passwordGm: "" };
  },
  methods: {
    togglePasswordVisibilityGm() {
      this.showPasswordGm = !this.showPasswordGm;
    },
  },
  components: { ImageFrame }
});
</script>
<style lang="scss">
@import '../scss/root.scss';
@import '../scss/login.scss';
</style>
