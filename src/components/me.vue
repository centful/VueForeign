<template>
<div>
  <el-row>
    <el-col :span="8">
      <img style="width:100px;height:100px;border-radius:100px" height="100px" width="100%" src="https://wx3.sinaimg.cn/orj480/61440fafly8ft7xgwncpwj20b40b4jtd.jpg">
    </el-col>
    <el-col :span="16" style="text-align:left;padding-left:10px;">
      <h3>I am Centful</h3>
      <p style="color: grey">一个很傻的东西</p>
      <!-- <i style="text-align:right;padding-right:10px;" class="el-icon-arrow-right"></i> -->
    </el-col>
  </el-row>
      <div style="margin-top:5px">
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
      </div>
      <el-button icon="el-icon-sold-out" style="width:100%;text-align:left;margin-top:25px;margin-left:0px;">我的购物车</el-button>
      <el-button icon="el-icon-view" style="width:100%;text-align:left;margin-top:25px;margin-left:0px;">商家详情</el-button>
      <el-button icon="el-icon-service" style="width:100%;text-align:left;margin-top:25px;margin-left:0px;">商家联系方式</el-button>
      <el-button icon="el-icon-message" style="width:100%;text-align:left;margin-top:25px;margin-left:0px;">商家微信</el-button>
      <el-button icon="el-icon-edit-outline" style="width:100%;text-align:left;margin-top:25px;margin-left:0px;">我要反馈</el-button>
      <div style="height:50px;"></div>
</div>
</template>

<script>
export default {
  name: 'me',
  data () {
    return {
      
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>