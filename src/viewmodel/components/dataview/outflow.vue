<template>
    <div class="square-block">
        <div class="uitstroom-label">Uitstroom:</div>
        <div class="uitstroom-number">{{ uitstroomNummer }}</div>
      <trend :uitstroomNummer="uitstroomNummer" />
    </div>
  </template>
  
  <script>

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
    height: 100%; 
    right: 100%; 
    top: 20vh; /* Gebruik vh om de positie te schalen met de viewport */
  
    /* Dropshadow */
    box-shadow: -3px 2px 12px 6px rgba(2, 81, 92, 0.08);
    border-radius: 16px;
  }
  
  .uitstroom-label {
    display: flex;
    justify-content: center;
    align-items: center;
    font-family: 'Inter';
    font-weight: 600;
    font-size: 2vw; /* Gebruik vw om de tekstgrootte te schalen met de viewport */
    color: black;
    margin-top: 10%;
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
    transform: translate(0%, 50%); 
  }
  </style>
