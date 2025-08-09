import { apiGet, apiPost, apiPut, apiDelete } from './api';
import { MasterBarang, CreateMasterBarangRequest, ApiResponse, PaginatedResponse } from '@/types';

export const inventoryService = {
  // Master Barang
  getMasterBarang: async (page: number = 1, pageSize: number = 10, search?: string): Promise<PaginatedResponse<MasterBarang>> => {
    const params = new URLSearchParams({
      page: page.toString(),
      pageSize: pageSize.toString(),
    });
    
    if (search) {
      params.append('search', search);
    }

    const response = await apiGet<ApiResponse<PaginatedResponse<MasterBarang>>>(`/inventory/master-barang?${params}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch master barang');
  },

  getMasterBarangById: async (id: string): Promise<MasterBarang> => {
    const response = await apiGet<ApiResponse<MasterBarang>>(`/inventory/master-barang/${id}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch master barang');
  },

  createMasterBarang: async (data: CreateMasterBarangRequest): Promise<MasterBarang> => {
    const response = await apiPost<ApiResponse<MasterBarang>>('/inventory/master-barang', data);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to create master barang');
  },

  updateMasterBarang: async (id: string, data: Partial<CreateMasterBarangRequest>): Promise<MasterBarang> => {
    const response = await apiPut<ApiResponse<MasterBarang>>(`/inventory/master-barang/${id}`, data);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to update master barang');
  },

  deleteMasterBarang: async (id: string): Promise<void> => {
    const response = await apiDelete<ApiResponse<void>>(`/inventory/master-barang/${id}`);
    if (!response.success) {
      throw new Error(response.message || 'Failed to delete master barang');
    }
  },

  // Stok Unit
  getStokUnit: async (page: number = 1, pageSize: number = 10): Promise<PaginatedResponse<any>> => {
    const response = await apiGet<ApiResponse<PaginatedResponse<any>>>(`/inventory/stok-unit?page=${page}&pageSize=${pageSize}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch stok unit');
  },

  // Supplier
  getSupplier: async (page: number = 1, pageSize: number = 10): Promise<PaginatedResponse<any>> => {
    const response = await apiGet<ApiResponse<PaginatedResponse<any>>>(`/inventory/supplier?page=${page}&pageSize=${pageSize}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch supplier');
  },

  // Pembelian
  getPembelian: async (page: number = 1, pageSize: number = 10): Promise<PaginatedResponse<any>> => {
    const response = await apiGet<ApiResponse<PaginatedResponse<any>>>(`/inventory/pembelian?page=${page}&pageSize=${pageSize}`);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Failed to fetch pembelian');
  },
};
