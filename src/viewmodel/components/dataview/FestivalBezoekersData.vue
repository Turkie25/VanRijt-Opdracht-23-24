<template>
  <div class="BezoekersBox">
    <h2 class="BezoekersText">Bezoekers</h2>
    <div>
      <h3 class="BezoekersInfoText">
        Huidig aantal:
        <span class="InstroomColor">{{ HuidigAantal.toLocaleString() }}</span>
      </h3>
      <h3 class="BezoekersInfoText">
        Piek:
        <span class="InstroomColor">{{ Piek.toLocaleString() }}</span>
      </h3>
      <h3 class="BezoekersInfoText">
        Maximale aantal:
        <span class="MaxColor">{{ MaxAantal.toLocaleString() }}</span>
      </h3>
    </div>
    <button class="WijzigenButton">Wijzigen</button>
  </div>
</template>


<script>
export default {
  data() {
    return {
      EventNaam: 'FurkansFestival',
      
      HuidigAantal: 14556,
      Piek: 16536,
      MaxAantal: 20000,
    };
  },
}
</script>


<style lang="scss">
@import '../../../view//scss/root.scss';

/* Container Styles */
.BezoekersBox {
  display: flex;
  flex-direction: column;
  background-color: $grayLight;
  font-weight: $thick;
  color: black;
  height: fit-content;
  width: 85%;
  filter: drop-shadow(-3px 2px 12px 6px rgba(2, 81, 92, 0.08));
  border-radius: 5%;
  margin: auto auto auto auto; 
  box-shadow: -3px 2px 12px 6px rgba(2, 81, 92, 0.08);

}

/* Text Styles */
.BezoekersText {
  margin: 5% auto 0 5%;
  margin-bottom: 2%;
}

.BezoekersInfoText {
  margin: 2% auto 0 5%;
  font-weight: $medium;
}

.InstroomColor {
    color: $primary;
}

.MaxColor {
    color: $secondary;
}

.WijzigenButton{
  background-color: $primary;
  width: 80%;
  height: 6vh;
  color: white;
  margin: 6% auto 0 auto;
  border-radius: 16px;

  font-size: 18px;
  font-weight: $regular;
  margin-bottom: 2%;
  border: none;
}
</style>