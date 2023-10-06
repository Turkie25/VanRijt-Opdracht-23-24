<template>
  <div class="LiveDataView">
  <dataViewCircle></dataViewCircle>
  <dataInformation></dataInformation>
</div>
</template>
<script>
import dataViewCircle from "../../viewmodel/components/dataViewCircle.vue"
import dataInformation from "../../viewmodel/components/dataInformation.vue"

export default {
  components: {
    dataViewCircle,
    dataInformation
    }
  // ...
}
</script>