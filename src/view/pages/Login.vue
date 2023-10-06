<template>
  <h2>Hello World</h2>
</template>
<script>
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
<<<<<<< Updated upstream
});
=======


})

>>>>>>> Stashed changes
</script>
<style lang="scss" module>
@import '../scss/root.scss';
.imageFrame{
  position: absolute;
  inset: 0;
  min-height: 100%;
  min-width: 100%;
  object-fit: cover;
  background-size: contain;
  background-image: url(../images/login.png);
  clip-path: polygon(0 0, 100% 0%, 50% 100%, 0% 100%);
}
</style>
