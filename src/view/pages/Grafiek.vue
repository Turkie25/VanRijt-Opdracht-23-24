<template>
  <div class="LiveDataView">
  <Grafiek></Grafiek>
</div>
</template>
<script>
import Grafiek from "../../viewmodel/components/grafiekComp.vue"
import { Bar } from 'vue-chartjs'

export default {
  name: 'App',
  components: {
    Grafiek,
    }
  // ...
}
</script>