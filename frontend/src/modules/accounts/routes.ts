import { ACCOUNT } from '@/router/router.constants';
import AccountPage from '@/modules/accounts/views/AccountPage.vue';

export default [
  {
    path: `/${ACCOUNT}`,
    name: ACCOUNT,
    component: AccountPage,
  },
]