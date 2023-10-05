<template>
  <div class="login">
    <div class="content">
      <div class="formWrapper">
        <h1>Login</h1>
        <form @submit.prevent="submitForm">
          <div>
            <label for="email">Email:</label>
            <input type="email" v-model="email" required>
          </div>
          <div>
            <label for="password">Password:</label>
            <input type="password" v-model="password" required>
          </div>
          <button type="submit" @click="sendLoginDataToApi">Submit</button>
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
