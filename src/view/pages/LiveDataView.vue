<template>
  <div class="LiveDataView">
  <dataViewCircle></dataViewCircle>
  <dataInformation></dataInformation>
  <FestivalBezoekersData></FestivalBezoekersData>
  <adminPaneluitlogBox></adminPaneluitlogBox>
</div>
</template>
<script>
import dataViewCircle from "../../viewmodel/components/dataViewCircle.vue"
import dataInformation from "../../viewmodel/components/dataInformation.vue"
import FestivalBezoekersData from "../../viewmodel/components/FestivalBezoekersData.vue"
import adminPaneluitlogBox from "../../viewmodel/components/adminPaneluitlogBox.vue"

export default {
  components: {
    dataViewCircle,
    dataInformation,
    FestivalBezoekersData,
    adminPaneluitlogBox
    }
  // ...
}
</script>