import { useAuth0 } from '@auth0/auth0-vue';

export const useAuthService = () => {
  const { getAccessTokenSilently, isAuthenticated, user, error, isLoading, loginWithRedirect, logout } = useAuth0();
  
  const getAuthHeaders = async () => {
    const token = await getAccessTokenSilently();
    return { Authorization: `Bearer ${token}` };
  };

  return { isAuthenticated, user, error, isLoading, loginWithRedirect, logout, getAuthHeaders };
};
