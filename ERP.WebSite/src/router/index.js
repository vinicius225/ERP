import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      meta : {layout : 'padrao'},
      component: HomeView
    },
    {
      path: '/about',
      name: 'about',
      meta : {layout : 'padrao'},
      component: () => import('../views/AboutView.vue')
    }
    ,
    {
      path: '/login',
      name: 'login',
      component: () => import('../views/LoginView.vue')
    }
  ]
})

export default router
