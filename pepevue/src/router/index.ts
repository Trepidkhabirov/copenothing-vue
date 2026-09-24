import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import authorization from '@/auth/authorization.vue'
import register  from '@/auth/register.vue'
import  profile  from '@/profile/profile.vue'
import mainmenu from '@/mainmenu/mainmenu.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/authorization',
      component: authorization
    },
    {
      path: '/register',
      component: register
    },
    {
      path: '/profile',
      component: profile
    },
    {
      path: '/mainmenu',
      component: mainmenu
    }
  ]
})

export default router
