<template>
    <div class="trend-block">
      <div class="trend-label">
          Trend
      </div>
      <div class="trend-icon">
        <img class="trend-images" v-if="instroomNummer > uitstroomNummer" src="../../../view/images/bx-trending-down.png" alt="Gaat omhoog">
        <img  class="trend-images" v-if="instroomNummer < uitstroomNummer" src="../../../view/images/bx-trending-down.png" alt="Gaat omlaag">
        <img  class="trend-images" v-if="instroomNummer === uitstroomNummer" src="../../../view/images/bx-trending-down.png" alt="Is gelijk">
      </div>
    </div>
</template>

<script>
import "https://unpkg.com/boxicons@2.1.4/dist/boxicons.js";
import "../../../view/images/bx-trending-down.png";

export default {
  data() {
    return {
      invoer: 22, // de invoer is waar je de API aan linkt en stuurt dan de cijfers naar instroomNummer
      uitvoer: 22
    };
  },
  computed: {
    uitstroomNummer() {
      return this.uitvoer;
    },
    instroomNummer() {
      return this.invoer;
    }
  }
};
</script>

<style lang="scss" scoped>
.trend-block {
  display: grid;
  justify-content: center;
  align-items: center;
  font-family: 'inter';
  font-weight: 600;
  font-size: 2vw;
  margin: auto;
  aspect-ratio: 1 / 1;
  height: 100%;
  width: 100%;
  background: #FFFFFF;
  box-shadow: -3px 2px 12px 6px rgba(2, 81, 92, 0.08);
  border-radius: 16px;
}

.trend-icon {
  font-size: 1vw;
  margin: auto;
  display: flex;
  justify-content: center; /* Center horizontally */
  align-items: center; /* Center vertically */
}

.trend-images {
  width: 70px;
  text-align: center;
  aspect-ratio: 1 / 1;
}
</style>