import { createRouter, createWebHistory } from 'vue-router'
import { authGuard } from '@/services/auth/authGuard';
import HomeView from '@/views/HomeView.vue'
import WarehouseRoutes from '@/modules/warehouse/routes';

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
    beforeEnter: authGuard,
  },
  ...WarehouseRoutes,
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
})

router.beforeEach(authGuard);

export default router
