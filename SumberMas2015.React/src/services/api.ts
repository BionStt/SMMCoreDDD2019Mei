import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { useAuthStore } from '@/store/authStore';

// Create axios instance
const createApiInstance = (): AxiosInstance => {
  const instance = axios.create({
    baseURL: process.env.REACT_APP_API_URL || 'https://localhost:5001/api',
    timeout: 30000,
    headers: {
      'Content-Type': 'application/json',
    },
  });

  // Request interceptor to add auth token
  instance.interceptors.request.use(
    (config) => {
      const token = useAuthStore.getState().token;
      if (token) {
        config.headers.Authorization = `Bearer ${token}`;
      }
      return config;
    },
    (error) => {
      return Promise.reject(error);
    }
  );

  // Response interceptor to handle errors
  instance.interceptors.response.use(
    (response: AxiosResponse) => {
      return response;
    },
    (error) => {
      if (error.response?.status === 401) {
        // Token expired or invalid
        useAuthStore.getState().logout();
        window.location.href = '/login';
      }
      return Promise.reject(error);
    }
  );

  return instance;
};

export const api = createApiInstance();

// Generic API functions
export const apiGet = <T>(url: string, config?: AxiosRequestConfig): Promise<T> => {
  return api.get(url, config).then(response => response.data);
};

export const apiPost = <T>(url: string, data?: any, config?: AxiosRequestConfig): Promise<T> => {
  return api.post(url, data, config).then(response => response.data);
};

export const apiPut = <T>(url: string, data?: any, config?: AxiosRequestConfig): Promise<T> => {
  return api.put(url, data, config).then(response => response.data);
};

export const apiDelete = <T>(url: string, config?: AxiosRequestConfig): Promise<T> => {
  return api.delete(url, config).then(response => response.data);
};

export const apiPatch = <T>(url: string, data?: any, config?: AxiosRequestConfig): Promise<T> => {
  return api.patch(url, data, config).then(response => response.data);
};
