<template>
  <div class="InformationBox">
    <h2 class="FestivalLabel">{{ EventNaam }}</h2>
     <div>
        <h3 class='In-Uit-stroomText'>Instroom: <span class='InstroomColor'>{{ Instroom }}</span></h3>
        <h3 class='In-Uit-stroomText'>Uitsroom: <span class='UitstroomColor'>{{ Uitstroom }}</span></h3>
     </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      EventNaam: 'FurkansFestival',
      
      Instroom: 253,
      Uitstroom: 400
    };
  },
}
</script>


<style lang="scss">
@import '../../../view//scss/root.scss';

/* Container Styles */
.InformationBox {
  display: flex;
  flex-direction: column;
  background-color: $grayLight;
  color: black;
  height: fit-content;
  border-radius: 5%;
  margin: 0 auto 0 auto; 
  box-shadow: -3px 2px 12px 6px rgba(124, 124, 124, 0.09);
}

/* Text Styles */
.FestivalLabel {
  margin: 3% auto 0 5%;
  margin-bottom: 2%;
  font-size: 3vh;
}

.In-Uit-stroomText {
  margin: 2% auto 0 5%;
  font-weight: $medium;
  font-size: 2.5vh;
}

.InstroomColor {
  color: $primary;
}

.UitstroomColor {
  color: $secondary;
}

</style>