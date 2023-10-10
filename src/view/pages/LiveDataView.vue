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
                <div class="peopleCounter"></div>
                <div class="block instroom"></div>
                <div class="block uitstroom"></div>
                <div class="block trend"></div> 
            </div>
        </div>
        <div class="graph">
        </div>
    </section>

    <section class="informationOverlay">
  <realTimeClock></realTimeClock>
  <weatherBlock></weatherBlock>
  <h3 class="Information">Informatie</h3>
  <weatherBlock></weatherBlock>
  <weatherBlock></weatherBlock>

  
</section>  

</div>
</template>
<script>
import dataViewCircle from "../../viewmodel/components/dataview/dataViewCircle.vue"
import realTimeClock  from "../../viewmodel/components/dataview/realTimeClock.vue"
import weatherBlock  from "../../viewmodel/components/dataview/weatherBlock.vue"
import profilePicture from "../../viewmodel/components/dataview/profilePicture.vue"
export default {
  components: {
    dataViewCircle, realTimeClock, weatherBlock, profilePicture
    }
  // ...
}
</script>
<style lang="scss">
@import '../../view/scss/root.scss';
@import '../../view/scss/livedataview.scss';
</style>
