<template>
    <div class="navbar">
      <nav>
        <ul>
            <li><router-link to="/"></router-link></li>
        </ul>
      </nav>
    </div>
  </template>
  

  <script>
  export default {
    name: 'navbar',
  };
  
  </script>

  
  <style scoped>
  .navbar {
    width: 450px;
    background-color: #FFF;
    color: #fff;
    padding: 20px;
    position: fixed;
    top: 0;
    right: 0;
    height: 100%;
  }
  
  ul {
    list-style: none;
    padding: 0;
  }
  
  li {
    margin-bottom: 10px;
  }

  router-link {
  color: #fff;
  text-decoration: none;
  }

  router-link:hover {
    
  color: #f39c12;
  }
  </style>
  