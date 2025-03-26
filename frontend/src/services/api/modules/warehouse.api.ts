import apiClient from '@/services/api/main.api';
import { ApiPaths } from '@/services/api/api.types';
import { PathBuilder } from '@/services/api/utils.api';

const sectionsPath = new PathBuilder().addString(ApiPaths.Warehouse).addString(ApiPaths.Sections).build();

const warehouseApi = {
  getAllSections: async () => {
    console.log('PATH', sectionsPath);
    const response = await apiClient.get(sectionsPath);
    console.log('GET ALL SECTIONS', response.data);
    return response.data;
  },
  getSectionById: async (id: string) => {
    const response = await apiClient.get(`${sectionsPath}/${id}`);
    return response.data;
  },
  createSection: async (data: { name: string; description: string }) => {
    const response = await apiClient.post(sectionsPath, data);
    return response.data;
  },
  deleteSection: async (id: string) => {
    const response = await apiClient.delete(`${sectionsPath}/${id}`);
    return response.data;
  },
};

export default warehouseApi;
