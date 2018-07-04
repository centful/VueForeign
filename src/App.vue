<template>
  <div id="app">
    <!-- <img src="./assets/logo.png"> -->
    <el-container>
      <el-main>
        <router-view/>
      </el-main>
      <el-footer style="height:55px;">
        <footermain></footermain>
      </el-footer>
    </el-container>
  </div>
</template>

<script>
import footermain from '@/components/footermain'
export default {
  name: 'App',
  components:{
    footermain
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
}
.el-footer{
  position:fixed;
  bottom:0;
  width: 100%;
}
</style>
