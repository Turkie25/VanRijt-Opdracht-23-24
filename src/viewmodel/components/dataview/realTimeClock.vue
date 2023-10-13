<template>
    <div class="realTimeClock">
        <h2>{{ currentTime }}</h2>
    </div>
  </template>
  
  <script>
  export default {
    name: 'realTimeClock',
    data() {
      return {
        currentTime: this.getCurrentTime()
      };
    },
    methods: {
      getCurrentTime() {
        const now = new Date();
        const hours = now.getHours().toString().padStart(2, '0');
        const minutes = now.getMinutes().toString().padStart(2, '0');
        return `${hours}:${minutes}`;
      },
      updateTime() {
        this.currentTime = this.getCurrentTime();
      }
    },
    mounted() {
      // update time every minute
      setInterval(this.updateTime, 60000);
    }
  };
  </script>
  
  <style scoped>  
  h2{
    color: #04A0B5;
    font-size: 13vh;
    font-family: 'Manrope';
  }
  </style>
  