<template>
<div>
	<el-row :gutter="0">
  		<el-col :span="18"><div class="grid-content bg-purple" style="float:left; font-size:24px;">Linda-Jamila</div></el-col>
  		<el-col :span="6"><div class="grid-content bg-purple" style="font-size:10px;">中文/English</div></el-col>
	</el-row>
	<el-row>
	<el-col :span="24">
	<img src="/static/official.png" style="width:100%;height:100%;">
	</el-col>
	</el-row>
	<el-carousel indicator-position="outside">
    <el-carousel-item v-for="item in 4" :key="item">
      <h3>{{ item }}</h3>
    </el-carousel-item>
  </el-carousel>
  <el-row>
  	<el-col :span="6">
  		<i class="el-icon-edit" style="font-size:34px"></i>
  		<div>时尚</div>
  	</el-col>
  	<el-col :span="6">
  		<i class="el-icon-bell" style="font-size:34px"></i>
  		<div>流行</div>
  	</el-col>
  	<el-col :span="6">
  		<i class="el-icon-goods" style="font-size:34px"></i>
  		<div>实惠</div>
  	</el-col>
  	<el-col :span="6">
  		<i class="el-icon-star-on" style="font-size:34px"></i>
  		<div>经典</div>
  	</el-col>
  </el-row>
  <el-row>
  	<el-col :span="24" style="padding-top:15px; font-size:18px;"> 爆款商品</el-col>
  </el-row>
  <div style="background-color:#E6A23C;height:200px;width:100%"></div>
  <el-row>
  	<el-col :span="12">
  	<p style=""> 	</p>
  	<div class="" style="height:150px;width:100px; background-color: #409EFF;text-align:center;margin-left:40px;"></div>
  	<p>时尚款式</p>
  	<p>￥ 35</p>
  	</el-col>
  	<el-col :span="12">
  	<p style=""> 	</p>
  	<div class="" style="height:150px;width:100px; background-color: #67C23A;text-align:center;margin-left:40px;"></div>
  	<p>时尚款式</p>
  	<p>￥ 35</p>
  	</el-col>
  </el-row>
    <el-row>
  	<el-col :span="12">
  	<p style=""> 	</p>
  	<div class="" style="height:150px;width:100px; background-color: #E6A23C;text-align:center;margin-left:40px;"></div>
  	<p>时尚款式</p>
  	<p>￥ 35</p>
  	</el-col>
  	<el-col :span="12">
  	<p style=""> 	</p>
  	<div class="" style="height:150px;width:100px; background-color: #909399;text-align:center;margin-left:40px;"></div>
  	<p>时尚款式</p>
  	<p>￥ 35</p>
  	</el-col>
  </el-row>
  <div style="height:50px;"></div>
</div>
</template>

<script>
export default {
  name: 'index',
  data () {
    return {
      msg: 'Welcome to index'
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
	 .el-carousel__item h3 {
    color: #475669;
    font-size: 18px;
    opacity: 0.75;
    line-height: 100px;
    margin: 0;
  }
  
  .el-carousel__item:nth-child(2n) {
    background-color: #99a9bf;
  }
  
  .el-carousel__item:nth-child(2n+1) {
    background-color: #d3dce6;
  }
</style>
