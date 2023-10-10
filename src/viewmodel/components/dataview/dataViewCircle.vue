<template>
  <div class="DataViewCircle">
    <h2 class="ActueleBezoekersText">Actuele bezoekers</h2>
    <div class="Container">
      <div class="CircularProgress" :style="circleStyle">
        <div class="ProgressValue">
          <div class="CurrentValue">Huidig</div> {{ current }}
          <div class="MaxValue"><p class="Max">Max {{ max }}</p></div>

        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      current: 253,
      max: 400
    };
  },
  computed: {
    currentAngle() {
      return (this.current / this.max) * 360;
    },
    circleStyle() {
      return {
        background: `conic-gradient(#E03076 ${this.currentAngle}deg, #EEF1F6 0deg)`,
      };
    },
  },
  methods: {
    calculateCircle() {
    }
  }
};
</script>

<style lang="scss" scoped>
@import '@/view/scss/root.scss';

/* Container Styles */
.DataViewCircle {
  display: flex;
  flex-direction: column;
  background-color: $primary;
  font-family: Manrope;
  color: $whiteLight;
  height: 100%;
  width: 100%;
  filter: drop-shadow(-3px 2px 12px 6px rgba(2, 81, 92, 0.08));
  border-radius: 5%;

}

/* Text Styles */
.ActueleBezoekersText {
  margin: 10% auto 0 auto;
}

/* Circular Progress Styles */
.CircularProgress {
  position: relative;
  display: flex;
  height: 80%;
  width: 80%;
  justify-content: center;
  align-items: center;
  margin: 20% auto auto auto; /* Adjust margin as needed */
  border-radius: 60%;
}

.CircularProgress::before {
  content: "";
  position: absolute;
  height: 75%;
  width: 75%;
  border-radius: 50%;
  background-color: $primary;
}

/* Progress Value Styles */
.ProgressValue {
  position: absolute;
}

/* Number Styles */
.Max {
  color: $secondary;
}
</style>



