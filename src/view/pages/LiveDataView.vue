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
                <div class="block instroom"></div>
                <div class="block uitstroom"></div>
                <div class="block trend"></div> 
            </div>
        </div>
        <dataGraph class="graph"></dataGraph> 
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
import dataGraph from "../../viewmodel/components/dataview/dataGraph.vue"

export default {
  components: {
    dataViewCircle, realTimeClock, weatherBlock, profilePicture, FestivalBezoekersData, dataInformation, visitorCount, dataGraph 
    }
  // ...
}
</script>
<style lang="scss">
@import '../../view/scss/root.scss';
@import '../../view/scss/livedataview.scss';
</style>
