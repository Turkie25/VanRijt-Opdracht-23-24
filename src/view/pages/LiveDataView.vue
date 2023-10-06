<template>
  <div class="LiveDataView">
  <dataViewCircle></dataViewCircle>
  <dataInformation></dataInformation>
  <FestivalBezoekersData></FestivalBezoekersData>
</div>
</template>
<script>
import dataViewCircle from "../../viewmodel/components/dataViewCircle.vue"
import dataInformation from "../../viewmodel/components/dataInformation.vue"
import FestivalBezoekersData from "../../viewmodel/components/FestivalBezoekersData.vue"

export default {
  components: {
    dataViewCircle,
    dataInformation,
    FestivalBezoekersData,
    }
  // ...
}
</script>