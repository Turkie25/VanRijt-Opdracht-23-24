<template>
    <div class="square-block">
      <div class="uitstroom">
        <div class="uitstroom-label">Uitstroom:</div>
        <div class="uitstroom-number">{{ uitstroomNummer }}</div>
      </div>
      <trend :uitstroomNummer="uitstroomNummer" />
    </div>
  </template>
  
  <script>
  import trend from "../../viewmodel/components/trend.vue";

  export default {
    
    data() {
      return {
      uitvoer: 11 // de invoer is waar je de api aan linked en stuurt dan de cijfers naar instroomnummer
    };
  },
  computed: {
    uitstroomNummer() {
      return this.uitvoer; 
    }
  }
  };
  </script>
  
  <style lang="scss" scoped>
  .square-block {
    aspect-ratio: 1 / 1;
    position: absolute;
    height: 20vh; /* Gebruik vh (viewport height) om de hoogte te schalen met de viewport */
    right: 28vw; /* Gebruik vw (viewport width) om de positie te schalen met de viewport */
    top: 20vh; /* Gebruik vh om de positie te schalen met de viewport */
  
    background: #FFFFFF;
    /* Dropshadow */
    box-shadow: -3px 2px 12px 6px rgba(2, 81, 92, 0.08);
    border-radius: 16px;
  
    /* Uitstroom */
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column; /* Stel flex-direction in op column om de tekst onder elkaar te plaatsen */
  }
  
  .uitstroom-label {
    display: flex;
    justify-content: center;
    align-items: center;
    font-family: 'Inter';
    font-weight: 600;
    font-size: 2vw; /* Gebruik vw om de tekstgrootte te schalen met de viewport */
    color: #E03076;
  }
  
  .uitstroom-number {
    display: flex;
    justify-content: center;
    align-items: center;
    font-family: 'Manrope';
    font-weight: 700;
    font-size: 3vw; /* Gebruik vw om de tekstgrootte te schalen met de viewport */
    color: #E03076;
    margin: auto; /* Centreer de tekst horizontaal en verticaal binnen het blok */
  }
  </style>
