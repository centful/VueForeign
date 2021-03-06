import Vue from 'vue'
import Router from 'vue-router'
//import HelloWorld from '@/components/HelloWorld'
import footermain from '@/components/footermain'
import index from '@/components/index'
import DongTai from '@/components/dongtai'
import Me from '@/components/me'
import Detail from '@/components/Detail'
Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'index',
      component: index
    },
    {
    	path:'/dongtai',
    	name:'dongtai',
    	component: DongTai
    },
    {
    	path:'/me',
    	name:'me',
    	component: Me
    },
    {
    	path:'/detail',
    	name:'detail',
    	component: Detail
    },
    {
    	path:'/index',
    	name:'index',
    	component: index
    }
  ]
})
