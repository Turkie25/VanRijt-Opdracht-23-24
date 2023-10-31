<template>
    <div class="profile">
        <!-- <img src="@/view/images/saul.jpg" alt="not wriwm"> -->
        <!-- <img :src=userProfile alt="User Profile Image"/> 
-->
<div class="profile">
  <div class="profilePicture"></div>
  <div class="profileText">VanRijt</div>
</div>
</div>
  </template>
  
  <script>
  export default {
  data() {
    return {
        userName: "Hallo",
        // userProfile: require("@/view/images/saul.jpg")
    };
  }}
  </script>

<style scoped>

.profile {
    display: flex;
    text-align: center;
}
.profilePicture{
height: 10vh;
border-radius: 50%;
background:  #000000;
aspect-ratio: 1 / 1;
margin: auto 5% auto auto;
}

.profileText {
  text-align: center;
  align-items: center;
  justify-content: center;
  margin: auto;
  font-size: 4vh;
}

</style>