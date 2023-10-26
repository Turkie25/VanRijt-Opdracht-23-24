<template> 
<div class="VisitorCount">
    <h2 class="Visitor">Bezoekersaantal:</h2>
    <h2 class="VisitorNumber">{{ visitorNumber }}</h2>
</div>
</template>

<script>
export default {
  data() {
    return {
        visitorNumber: 33 // de invoer is waar je de api aan linked en stuurt dan de cijfers naar instroomnummer
    };
  },
  computed: {
    visitorCount() {
      return this.visitorNumber; 
    }
  }
}

</script>


<style lang="scss" scoped>
@import '@/view/scss/root.scss';


.VisitorCount {
    display: flex;
    align-items: center;
    border-radius: 16px;
    height: 40%;
}

.Visitor {
    margin:0 0 0 7%;
    font-size: 5vh;
}

.VisitorNumber {
  display: flex;
  width: 100%;
  color: $primary;
  font-family: $bold;
  justify-content: center;
  font-size: 5vh;
}
</style>