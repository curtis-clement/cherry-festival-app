import { createRouter, createWebHistory } from 'vue-router'
import { authGuard } from '@/services/auth/authGuard';
import HomeView from '@/views/HomeView.vue'
import WarehouseRoutes from '@/modules/warehouse/routes';
import AccountRoutes from '@/modules/accounts/routes';

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView,
    beforeEnter: authGuard,
  },
  ...AccountRoutes,
  ...WarehouseRoutes,
]

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes,
})

router.beforeEach(authGuard);

export default router
