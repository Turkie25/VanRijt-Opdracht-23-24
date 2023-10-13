<template>
  <div class="InformationBox">
    <h2 class="FestivalText">{{ EventNaam }}</h2>
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
  width: 85%;
  filter: drop-shadow(-3px 2px 12px 6px rgba(2, 81, 92, 0.08));
  border-radius: 5%;
  margin: 0 auto 0 auto; 
}

/* Text Styles */
.FestivalText {
  margin: 3% auto 0 5%;
  margin-bottom: 2%;
}

.In-Uit-stroomText {
  margin: 2% auto 0 5%;
}

.InstroomColor {
  color: $primary;
}

.UitstroomColor {
  color: $secondary;
}

</style>