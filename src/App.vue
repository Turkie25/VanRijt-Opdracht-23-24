<template>
  <div>
    <LiveDataView/>
  </div>
</template>

<script>
import LiveDataView from "views/LiveDataView"


export default {
  name: 'App',
  components: {
    LiveDataView,
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

body{all: unset;}
</style>