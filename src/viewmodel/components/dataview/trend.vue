<template>
  <div class="trend-block">
      <div class="trend-label">
          Trend:
      </div>
      <div class="trend-call">
            {{ invoer < uitvoer ? "Uitstromend" : (invoer > uitvoer ? "Instromend" : "Hetzelfde") }}
        </div>
      <div class="trend-icon">
          <img class="trend-images" v-if="invoer > uitvoer" src="../../../view/images/trending-up.png" alt="Gaat omhoog">
          <img class="trend-images" v-if="invoer < uitvoer" src="../../../view/images/trending-down.png" alt="Gaat omlaag">
          <img class="trend-images" v-if="invoer === uitvoer" src="../../../view/images/trending-same.png" alt="Is gelijk">
      </div>
  </div>
</template>

<script>

export default {
  data() {
    return {
      invoer: 12, // de invoer is waar je de API aan linkt en stuurt dan de cijfers naar instroomNummer
      uitvoer: 11
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
  justify-content: center; /* Center horizontally /
  align-items: center; / Center vertically */
  .trend-icon{
    object-fit: contain;
  }
}

.trend-images {
  width: 110px;
  text-align: center;
  aspect-ratio: 1 / 1;
}
</style>