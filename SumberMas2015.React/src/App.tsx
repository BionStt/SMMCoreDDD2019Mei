import React from 'react';
import { Routes, Route, Navigate } from 'react-router-dom';
import { Layout } from 'antd';

import AppLayout from '@/components/Layout/AppLayout';
import Login from '@/pages/Auth/Login';
import Dashboard from '@/pages/Dashboard/Dashboard';
import MasterBarang from '@/pages/Inventory/MasterBarang';
import DataKonsumen from '@/pages/SalesMarketing/DataKonsumen';
import DataPenjualan from '@/pages/SalesMarketing/DataPenjualan';
import DataSPK from '@/pages/SalesMarketing/DataSPK';
import DataPerusahaan from '@/pages/Organization/DataPerusahaan';
import DataPegawai from '@/pages/HumanCapital/DataPegawai';
import { useAuthStore } from '@/store/authStore';

const { Content } = Layout;

function App() {
  const { isAuthenticated } = useAuthStore();

  // Public routes that don't require authentication
  const PublicRoutes = () => (
    <Routes>
      <Route path="/login" element={<Login />} />
      <Route path="*" element={<Navigate to="/login" replace />} />
    </Routes>
  );

  // Protected routes that require authentication
  const ProtectedRoutes = () => (
    <AppLayout>
      <Routes>
        <Route path="/" element={<Navigate to="/dashboard" replace />} />
        <Route path="/dashboard" element={<Dashboard />} />
        
        {/* Inventory Module */}
        <Route path="/inventory/master-barang" element={<MasterBarang />} />
        
        {/* Sales Marketing Module */}
        <Route path="/sales-marketing/konsumen" element={<DataKonsumen />} />
        <Route path="/sales-marketing/penjualan" element={<DataPenjualan />} />
        <Route path="/sales-marketing/spk" element={<DataSPK />} />
        
        {/* Organization Module */}
        <Route path="/organization/perusahaan" element={<DataPerusahaan />} />
        
        {/* Human Capital Module */}
        <Route path="/human-capital/pegawai" element={<DataPegawai />} />
        
        {/* Fallback */}
        <Route path="/login" element={<Navigate to="/dashboard" replace />} />
        <Route path="*" element={<Navigate to="/dashboard" replace />} />
      </Routes>
    </AppLayout>
  );

  return (
    <div className="app-container">
      {isAuthenticated ? <ProtectedRoutes /> : <PublicRoutes />}
    </div>
  );
}

export default App;
