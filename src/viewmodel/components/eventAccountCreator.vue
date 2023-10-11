<template>
    <div class="container">
      <div class="eventAccountForm">
        <h2 class="form-title">MAAK EEN EVENEMENT AAN</h2>
  
        <div class="form-item" v-for="(field, index) in formFields" :key="index">
          <label :for="field.id">{{ field.label }}</label>
          <input :type="field.type" :id="field.id" v-model="field.value">
        </div>
  
        <div class="form-item">
          <button @click="createEvent" id="createEventButton">maak event</button>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    data() {
      return {
        formFields: [
          { id: 'eventAccountName', label: 'naam van event', type: 'text', value: '' },
          { id: 'eventAccountDate', label: 'maximum aantal bezoekers', type: 'text', value: '' },
          { id: 'eventAccountLocation', label: 'begin datum van event', type: 'text', value: '' },
          { id: 'eventAccountDescription', label: 'eind datum van event', type: 'text', value: '' },
          { id: 'eventAccountCategory', label: 'event adres', type: 'text', value: '' }
        ]
      };
    },
    methods: {
      createEvent() {
        // Handle event creation logic here
        console.log('Creating event:', this.formFields);
        // Reset form fields after event creation if needed
        this.formFields.forEach(field => {
          field.value = '';
        });
      }
    }
  };
  </script>
  
  <style>
  .eventAccountForm {
    width: 380px;
    background: #eef1f6;
    border-radius: 16px;
    padding: 20px;
    text-align: center;
  }
  
  .form-title {
    font-family: 'Inter';
    font-weight: 400;
    font-size: 26px;
    line-height: 31px;
    color: #000000;
    margin-bottom: 40px;
  }
  
  .form-item {
    margin-bottom: 15px;
  }
  
  label {
    font-family: 'Inter';
    font-style: normal;
    font-weight: 200;
    font-size: 16px;
    line-height: 22px;
    width: 100%;
    text-align: left;
    display: block;
    color: #6d6d6d;
  }

  input {
    transition: border-color 0.3s ease-in-out;
    width: 100%;
    padding: 10px;
    box-sizing: border-box;
    border-radius: 5px;
    border: 2px solid #ffffff;
    font-size: 15px;
    margin-top: 5px;
    margin-bottom: 20px;
  }
  
  input:hover {
  border: 2px solid #E03076; /* Change the color to red when selected */
}

  button {
    width: 40%;
    padding: 10px;
    background-color: #04A0B5 ;
    border: 2px solid #04A0B5;
    border-radius: 5px;
    color: rgb(255, 255, 255);
    font-size: 17px;
    cursor: pointer;
  }

  button:hover{
    transition: .5s;
    background-color: #fff;
    color: #04A0B5;
    border: 2px solid #04A0B5;
  }
  </style>
  