import { apiPost } from './api';
import { LoginRequest, LoginResponse, ApiResponse } from '@/types';

export const authService = {
  login: async (credentials: LoginRequest): Promise<LoginResponse> => {
    const response = await apiPost<ApiResponse<LoginResponse>>('/auth/login', credentials);
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Login failed');
  },

  logout: async (): Promise<void> => {
    await apiPost('/auth/logout');
  },

  refreshToken: async (): Promise<LoginResponse> => {
    const response = await apiPost<ApiResponse<LoginResponse>>('/auth/refresh');
    if (response.success) {
      return response.data;
    }
    throw new Error(response.message || 'Token refresh failed');
  },

  changePassword: async (oldPassword: string, newPassword: string): Promise<void> => {
    const response = await apiPost<ApiResponse<void>>('/auth/change-password', {
      oldPassword,
      newPassword,
    });
    if (!response.success) {
      throw new Error(response.message || 'Password change failed');
    }
  },

  resetPassword: async (email: string): Promise<void> => {
    const response = await apiPost<ApiResponse<void>>('/auth/reset-password', { email });
    if (!response.success) {
      throw new Error(response.message || 'Password reset failed');
    }
  },
};
