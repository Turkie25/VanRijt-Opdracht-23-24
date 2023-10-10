<template>
    <div class="profile">
        <!-- <img src="@/view/images/saul.jpg" alt="not wriwm"> -->
        <!-- <img :src=userProfile alt="User Profile Image"/> 
-->
<div class="profilePicture"></div>
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
}
.profilePicture{
height: 10vh;
border-radius: 50%;
background:  #000000;
aspect-ratio: 1 / 1;
}

.test {
    height: 100%;
    width: 100%;
    color: black;
}


</style>