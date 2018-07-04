<template>
<div>
  <el-row class="myFoot">
    <el-col :span='8' >
    <router-link to='/index'>
      <i class="icon iconfont icon-dianpu"></i>
      <div>首页</div>
    </router-link>
    </el-col>
    <el-col :span='8'>
    <router-link to='/dongtai'>
      <i class="icon iconfont icon-huiyuanqia"></i>
      <div>动态</div>
    </router-link>
    </el-col>
    <el-col :span='8'>
    <router-link to='/me'>
      <i class="icon iconfont icon-wodezichan"></i>
      <div>我</div>
    </router-link>
    </el-col>
  </el-row>
</div>
</template>

<script>
export default {
  name: 'footermain',
  data () {
    return {
      
    }
  },
  methods: {
    
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    .iconfont{
       font-size:30px;
    }
    .myFoot{
      border-top: 1px solid #123;
      background-color: white;
    }
    
</style>
