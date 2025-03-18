import Warehouse from '@/modules/warehouse/views/Warehouse.vue'
import { WAREHOUSE } from '@/router/router.constants'

export default [
  {
    path: `/${WAREHOUSE}`,
    name: WAREHOUSE,
    component: Warehouse,
  }
]