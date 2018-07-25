<template>
<div>
    <el-carousel indicator-position="outside">
      <el-carousel-item v-for="item in 4" :key="item">
        <h3>{{ item }}</h3>
      </el-carousel-item>
  </el-carousel>
  <div style="text-align:left;">
    <h3>时尚靓丽服装</h3>
    <p style="color:grey">这是今年最流行的服装，国内外大卖。为本店最畅销的热品</p>
    <h1 style="color:red;">￥50</h1>
    <p>产品规格：</p>
    <el-button>M</el-button>
    <el-button>L</el-button>
    <el-button>XL</el-button>
    <el-button>XXL</el-button>
    <div style="border:1px solid grey;width:100%; margin-top:10px;"></div>
    <h2>这是产品详情介绍</h2>
    <div>
      <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS60rwIrFyUQkPjtE9Yw57taUbtfvCE3x8JCO_Oku3z08oAz0T15w" width="100%" >
      <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQHCbR9etan6UL142inhFPTo6FOd6QGa6owv4CfHUrbxt5hrCzV" width="100%" >
    </div>
  </div>
  <div style="height:50px;"></div>
</div>
</template>

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