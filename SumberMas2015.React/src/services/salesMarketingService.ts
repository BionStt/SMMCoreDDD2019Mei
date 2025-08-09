import { apiGet, apiPost, apiPut, apiDelete } from './api';
import { DataKonsumen, DataPenjualan, DataSPK, ApiResponse, PaginatedResponse } from '@/types';

export const salesMarketingService = {
  // Data Konsumen
  getKonsumen: async (page: number = 1, pageSize: number = 10, search?: string): Promise<PaginatedResponse<DataKonsumen>> => {
    const params = new URLSearchParams({
      page: page.toString(),
      pageSize: pageSize.toString(),
    });
    
    if (search) {
      params.append('search', search);
    }

    const response = await apiGet<ApiResponse<PaginatedResponse<DataKonsumen>>>(`/sales-marketing/konsumen?${params}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch konsumen');
  },

  getKonsumenById: async (id: string): Promise<DataKonsumen> => {
    const response = await apiGet<ApiResponse<DataKonsumen>>(`/sales-marketing/konsumen/${id}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch konsumen');
  },

  createKonsumen: async (data: Omit<DataKonsumen, 'id' | 'createdDate' | 'updatedDate'>): Promise<DataKonsumen> => {
    const response = await apiPost<ApiResponse<DataKonsumen>>('/sales-marketing/konsumen', data);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to create konsumen');
  },

  updateKonsumen: async (id: string, data: Partial<DataKonsumen>): Promise<DataKonsumen> => {
    const response = await apiPut<ApiResponse<DataKonsumen>>(`/sales-marketing/konsumen/${id}`, data);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to update konsumen');
  },

  deleteKonsumen: async (id: string): Promise<void> => {
    const response = await apiDelete<ApiResponse<void>>(`/sales-marketing/konsumen/${id}`);
    if (!response.success) {
      throw new Error(response.message || 'Failed to delete konsumen');
    }
  },

  // Data Penjualan
  getPenjualan: async (page: number = 1, pageSize: number = 10, search?: string): Promise<PaginatedResponse<DataPenjualan>> => {
    const params = new URLSearchParams({
      page: page.toString(),
      pageSize: pageSize.toString(),
    });
    
    if (search) {
      params.append('search', search);
    }

    const response = await apiGet<ApiResponse<PaginatedResponse<DataPenjualan>>>(`/sales-marketing/penjualan?${params}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch penjualan');
  },

  getPenjualanById: async (id: string): Promise<DataPenjualan> => {
    const response = await apiGet<ApiResponse<DataPenjualan>>(`/sales-marketing/penjualan/${id}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch penjualan');
  },

  // Data SPK
  getSPK: async (page: number = 1, pageSize: number = 10, search?: string): Promise<PaginatedResponse<DataSPK>> => {
    const params = new URLSearchParams({
      page: page.toString(),
      pageSize: pageSize.toString(),
    });
    
    if (search) {
      params.append('search', search);
    }

    const response = await apiGet<ApiResponse<PaginatedResponse<DataSPK>>>(`/sales-marketing/spk?${params}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch SPK');
  },

  getSPKById: async (id: string): Promise<DataSPK> => {
    const response = await apiGet<ApiResponse<DataSPK>>(`/sales-marketing/spk/${id}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch SPK');
  },

  createSPK: async (data: Omit<DataSPK, 'id' | 'createdDate'>): Promise<DataSPK> => {
    const response = await apiPost<ApiResponse<DataSPK>>('/sales-marketing/spk', data);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to create SPK');
  },

  updateSPK: async (id: string, data: Partial<DataSPK>): Promise<DataSPK> => {
    const response = await apiPut<ApiResponse<DataSPK>>(`/sales-marketing/spk/${id}`, data);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to update SPK');
  },

  deleteSPK: async (id: string): Promise<void> => {
    const response = await apiDelete<ApiResponse<void>>(`/sales-marketing/spk/${id}`);
    if (!response.success) {
      throw new Error(response.message || 'Failed to delete SPK');
    }
  },
};
