<template>
  <div>
    <el-card class="box-card" shadow="hover">
      <div slot="header" class="clearfix" style="text-align:left">
        <span>今天又新进了一批货啦，亲们有兴趣的可以看一下哦</span>
      </div>
      <el-row :gutter="12">
        <el-col :span="8">
          <img :src="src" class="image" height="100px" width="100%"/>
        </el-col>
        <el-col :span="8">
          <img :src="src" class="image"  height="100px" width="100%"/>
        </el-col>
        <el-col :span="8">
          <img :src="src" class="image"  height="100px" width="100%"/>
        </el-col>
      </el-row>
    </el-card>
  </div>
</template>

<script>
export default {
    name: "footermain",
    data() {
        return {
          src: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRKPEJr7I5DBpj5KzTR4C3wMp_43X-FAX2wny8OxoDaUzL-PQqK2w'
        };
    }
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
