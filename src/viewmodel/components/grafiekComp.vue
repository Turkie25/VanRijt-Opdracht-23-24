<template>
  <div class="Grafiek">
    <Line :data="data" :options="options" />
  </div>
</template>

<script lang="ts">
import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
  
} from "chart.js";
import { Line } from "vue-chartjs";
import * as chartConfig from "@/chartConfig.js";

ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
  
);

export default {
  name: "App",
  components: {
    Line,
  },
  data() {
    return chartConfig;
  },
};
</script>

<style lang="scss">
@import "../../view/scss/root.scss";

.Grafiek {
  width: 1069px;
  height: 390px;
}
</style>
