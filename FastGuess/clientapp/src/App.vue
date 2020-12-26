<template>
  <div id="app">
    <img alt="Vue logo" src="./assets/logo.png">
    <HelloWorld msg="Welcome to Your Vue.js App"/>
    <ScoreBoard />
  </div>
</template>

<script>
import ScoreBoard from "@/components/ScoreBoard.vue"
import HelloWorld from './components/HelloWorld.vue'
import Picture from './components/Picture.vue'

fetch('http://localhost:5000/picture')
  .then(response => response.json())
  .then(data => 
    
  );


export default {
  name: 'app',
  components: {
    HelloWorld,
    ScoreBoard,
    Picture
  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
