<template>
  <div class="dataview">
    <section class="dataviewOverlay">
      <header >
        <profilePicture class="logo"></profilePicture>
        <profilePicture class="dropdown"></profilePicture>
      </header>
        <div class="dropdown"></div>   
        <div class="datablocks">
          <dataViewCircle class="dataViewCircle"></dataViewCircle>
          <div class="blockWrapper">
            <visitorCount class="peopleCounter"></visitorCount>
                <inflow class="block instroom"></inflow>
                <outflow class="block uitstroom"></outflow>
                <trend class="block trend"></trend> 
            </div>
        </div>
        <dataGraph class="graph">
        <Grafiek></Grafiek>
        </dataGraph> 
    </section>

    <section class="informationOverlay">
  <realTimeClock class="realTimeClock"></realTimeClock>
  <weatherBlock></weatherBlock>
  <h3 class="Information">Informatie</h3>
  <dataInformation class="dataInformation"></dataInformation>  
  <FestivalBezoekersData class="FestivalBezoekersData"></FestivalBezoekersData>
</section>  

</div>
</template>
<script>
import dataViewCircle from "../../viewmodel/components/dataview/dataViewCircle.vue"
import realTimeClock  from "../../viewmodel/components/dataview/realTimeClock.vue"
import weatherBlock  from "../../viewmodel/components/dataview/weatherBlock.vue"
import profilePicture from "../../viewmodel/components/dataview/profilePicture.vue"
import FestivalBezoekersData from "../../viewmodel/components/dataview/FestivalBezoekersData.vue"
import dataInformation from "../../viewmodel/components/dataview/dataInformation.vue"
import visitorCount from "../../viewmodel/components/dataview/visitorCount.vue"
import inflow from "../../viewmodel/components/dataview/inflow.vue"
import outflow from "../../viewmodel/components/dataview/outflow.vue"
import trend from "../../viewmodel/components/dataview/trend.vue"

import Grafiek from "../../viewmodel/components/grafiekComp.vue"
import { Bar } from 'vue-chartjs'

export default {
  components: {
    dataViewCircle, realTimeClock, weatherBlock, profilePicture, 
    FestivalBezoekersData, dataInformation, inflow, outflow, trend,
    visitorCount,Grafiek
    }
  // ...
}
</script>
<style lang="scss">
@import '../../view/scss/root.scss';
@import '../../view/scss/livedataview.scss';
</style>
