<template>
  <div class="square-block">
      <div class="instroom-label">Instroom:</div>
      <div class="instroom-number">{{ instroomNummer }}</div>
    <trend :instroomNummer="instroomNummer" /> <!-- Geef instroomNummer door als prop aan trend.vue -->
  </div>
</template>

<script>
import cameraData2 from "../../../model/cameraData.js"

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
  },
  methods: {
  async fetchCameraData() {
    console.log("hallo");

    try {
      const cameraData = await cameraData2();
      console.log("Fetched Camera Data:", cameraData); // Log the data to the console
      this.cameraData = cameraData; // Store the data in a component data property
    } catch (error) {
      console.error("Error fetching camera data:", error);
    }
  }
},
created() {
    this.fetchCameraData(); // Call the method when the component is created
  }
};


</script>

<style lang="scss" scoped>
@import '@/view/scss/root.scss';
.square-block {
    height: 100%; 
    right: 100%; 
    top: 100%; /* Gebruik vh om de positie te schalen met de viewport */
  
    /* Dropshadow */
    box-shadow: -3px 2px 12px 6px rgba(2, 81, 92, 0.08);
    border-radius: 16px;
}

.instroom-label {
  display: flex;
    justify-content: center;
    align-items: center;
    font-family: 'Inter';
    font-weight: 600;
    font-size: 2vw; /* Gebruik vw om de tekstgrootte te schalen met de viewport */
    color: black;
    margin-top: 10%;
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
    transform: translate(0%, 50%); 
}
</style>