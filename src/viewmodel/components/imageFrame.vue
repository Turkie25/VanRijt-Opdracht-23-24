<template>
    <div class="imageFrame"></div>
</template>
<script>
    import { defineComponent } from 'vue';

    export default defineComponent(
        {
            name: "imageFrame",
        }
    )
</script>
<style lang="scss">
@import '../../view/scss/root.scss';
@import '../../view/scss/login.scss';
.imageFrame{
  position: absolute;
  inset: 0;
  min-height: 100%;
  min-width: 100%;
  object-fit: cover;
  background-size: cover;
  background-image: url(../../view/images/login.png);
  clip-path: polygon(0 0, 70% 0%, 58% 100%, 0% 100%);
  @media (max-width: $md){
    clip-path: none;
  }
}
</style>