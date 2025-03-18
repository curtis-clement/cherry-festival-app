import axios, { type AxiosInstance } from 'axios';
import { useAuthService } from '@/services/auth/authService';

const addInterceptors = (instance: AxiosInstance) => {
  try {
    instance.interceptors.request.use(async (config) => {
      const authService = useAuthService();
      const authHeader = await authService.getAuthHeaders();
      config.headers.set('Authorization', authHeader.Authorization);
      
      return config;
    });
  } catch (error) {
    console.error('Error adding interceptors:', error);
    return Promise.reject(error);
  }
};

const apiClient = addInterceptors(axios.create({
  baseURL: import.meta.env.VITE_API_URL,
}));

export default apiClient;
