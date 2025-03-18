import { useAuth0 } from '@auth0/auth0-vue';
import { useAuthService } from './authService';
import type { NavigationGuardNext, RouteLocationNormalized } from 'vue-router';

export const authGuard = async (
  to: RouteLocationNormalized,
  from: RouteLocationNormalized,
  next: NavigationGuardNext
) => {
  const authService = useAuthService();
  
  // If this is a callback from Auth0, allow it
  if (to.query.state) {
    next();
    return;
  }
  
  if (authService.isAuthenticated.value) {
    next();
  } else {
    await authService.loginWithRedirect({ appState: { targetUrl: to.fullPath } });
  }
};