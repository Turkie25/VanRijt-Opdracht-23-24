<template>
  <div class="square-block">
    <div class="instroom">
      <div class="instroom-label">Instroom:</div>
      <div class="instroom-number">{{ instroomNummer }}</div>
    </div>
    <trend :instroomNummer="instroomNummer" /> <!-- Geef instroomNummer door als prop aan trend.vue -->
  </div>
</template>

<script>
import trend from "../../viewmodel/components/trend.vue"; // Importeer de Trend component

export default {
  
  data() {
    return {
      invoer: 33 // de invoer is waar je de api aan linked en stuurt dan de cijfers naar instroomnummer
    };
  },
  computed: {
    instroomNummer() {
      return this.invoer; 
    }
  }
};
</script>

<style lang="scss" scoped>
@import '../../view/scss/root.scss';
.square-block {
  aspect-ratio: 1 / 1;
  position: absolute;
  height: 20vh; /* Gebruik vh (viewport height) om de hoogte te schalen met de viewport */
  right: 40vw; /* Gebruik vw (viewport width) om de positie te schalen met de viewport */
  top: 20vh; /* Gebruik vh om de positie te schalen met de viewport */

  background: #FFFFFF;
  /* Dropshadow */
  box-shadow: $boxShadow;
  border-radius: 16px;

  /* Instroom */
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column; /* Stel flex-direction in op column om de tekst onder elkaar te plaatsen */
}

.instroom-label {
  display: flex;
    justify-content: center;
    align-items: center;
  font-family: 'Inter';
  font-weight: 600;
  font-size: 2vw; /* Gebruik vw om de tekstgrootte te schalen met de viewport */
  color: $primary;
}

.instroom-number {
  display: flex;
    justify-content: center;
    align-items: center;
  font-family: 'Manrope';
  font-weight: 700;
  font-size: 3vw; /* Gebruik vw om de tekstgrootte te schalen met de viewport */
  color: $primary;
  margin: auto; /* Centreer de tekst horizontaal en verticaal binnen het blok */
}
</style>