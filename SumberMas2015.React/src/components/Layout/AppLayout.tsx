import React, { useState } from 'react';
import { Layout, Menu, Dropdown, Avatar, Button, theme, Typography } from 'antd';
import {
  MenuFoldOutlined,
  MenuUnfoldOutlined,
  DashboardOutlined,
  ShoppingCartOutlined,
  TeamOutlined,
  BankOutlined,
  UserOutlined,
  LogoutOutlined,
  SettingOutlined,
  InboxOutlined,
  ShopOutlined,
  FileTextOutlined,
} from '@ant-design/icons';
import { useNavigate, useLocation } from 'react-router-dom';
import { useAuthStore } from '@/store/authStore';

const { Header, Sider, Content } = Layout;
const { Text } = Typography;

interface AppLayoutProps {
  children: React.ReactNode;
}

const AppLayout: React.FC<AppLayoutProps> = ({ children }) => {
  const [collapsed, setCollapsed] = useState(false);
  const navigate = useNavigate();
  const location = useLocation();
  const { user, logout } = useAuthStore();
  const { token: { colorBgContainer } } = theme.useToken();

  const handleMenuClick = (key: string) => {
    navigate(key);
  };

  const handleLogout = () => {
    logout();
    navigate('/login');
  };

  const userMenuItems = [
    {
      key: 'profile',
      icon: <UserOutlined />,
      label: 'Profile',
    },
    {
      key: 'settings',
      icon: <SettingOutlined />,
      label: 'Settings',
    },
    {
      type: 'divider',
    },
    {
      key: 'logout',
      icon: <LogoutOutlined />,
      label: 'Logout',
      onClick: handleLogout,
    },
  ];

  const menuItems = [
    {
      key: '/dashboard',
      icon: <DashboardOutlined />,
      label: 'Dashboard',
    },
    {
      key: 'inventory',
      icon: <InboxOutlined />,
      label: 'Inventory',
      children: [
        {
          key: '/inventory/master-barang',
          label: 'Master Barang',
        },
        {
          key: '/inventory/stok-unit',
          label: 'Stok Unit',
        },
        {
          key: '/inventory/supplier',
          label: 'Supplier',
        },
        {
          key: '/inventory/pembelian',
          label: 'Pembelian',
        },
      ],
    },
    {
      key: 'sales-marketing',
      icon: <ShoppingCartOutlined />,
      label: 'Sales & Marketing',
      children: [
        {
          key: '/sales-marketing/konsumen',
          label: 'Data Konsumen',
        },
        {
          key: '/sales-marketing/penjualan',
          label: 'Data Penjualan',
        },
        {
          key: '/sales-marketing/spk',
          label: 'Data SPK',
        },
      ],
    },
    {
      key: 'organization',
      icon: <BankOutlined />,
      label: 'Organization',
      children: [
        {
          key: '/organization/perusahaan',
          label: 'Data Perusahaan',
        },
        {
          key: '/organization/cabang',
          label: 'Data Cabang',
        },
        {
          key: '/organization/struktur',
          label: 'Struktur Organisasi',
        },
      ],
    },
    {
      key: 'human-capital',
      icon: <TeamOutlined />,
      label: 'Human Capital',
      children: [
        {
          key: '/human-capital/pegawai',
          label: 'Data Pegawai',
        },
        {
          key: '/human-capital/absensi',
          label: 'Data Absensi',
        },
        {
          key: '/human-capital/hari-libur',
          label: 'Hari Libur',
        },
      ],
    },
    {
      key: 'accounting',
      icon: <FileTextOutlined />,
      label: 'Accounting',
      children: [
        {
          key: '/accounting/chart-of-accounts',
          label: 'Chart of Accounts',
        },
        {
          key: '/accounting/journals',
          label: 'Journals',
        },
        {
          key: '/accounting/reports',
          label: 'Reports',
        },
      ],
    },
  ];

  const getSelectedKeys = () => {
    return [location.pathname];
  };

  const getOpenKeys = () => {
    const pathSegments = location.pathname.split('/');
    if (pathSegments.length > 2) {
      return [pathSegments[1]];
    }
    return [];
  };

  return (
    <Layout style={{ minHeight: '100vh' }}>
      <Sider 
        trigger={null} 
        collapsible 
        collapsed={collapsed}
        className="sidebar"
        theme="dark"
      >
        <div style={{ 
          height: 64, 
          display: 'flex', 
          alignItems: 'center', 
          justifyContent: 'center',
          borderBottom: '1px solid #333'
        }}>
          <Text style={{ color: 'white', fontWeight: 'bold', fontSize: collapsed ? 14 : 16 }}>
            {collapsed ? 'SM' : 'SumberMas ERP'}
          </Text>
        </div>
        <Menu
          theme="dark"
          mode="inline"
          selectedKeys={getSelectedKeys()}
          defaultOpenKeys={getOpenKeys()}
          items={menuItems}
          onClick={({ key }) => handleMenuClick(key)}
        />
      </Sider>
      
      <Layout>
        <Header style={{ 
          padding: 0, 
          background: colorBgContainer,
          display: 'flex',
          justifyContent: 'space-between',
          alignItems: 'center',
          borderBottom: '1px solid #f0f0f0'
        }}>
          <Button
            type="text"
            icon={collapsed ? <MenuUnfoldOutlined /> : <MenuFoldOutlined />}
            onClick={() => setCollapsed(!collapsed)}
            style={{
              fontSize: '16px',
              width: 64,
              height: 64,
            }}
          />
          
          <div style={{ marginRight: 24 }}>
            <Dropdown
              menu={{ 
                items: userMenuItems,
                onClick: ({ key }) => {
                  if (key !== 'logout') {
                    handleMenuClick(`/${key}`);
                  }
                }
              }}
              placement="bottomRight"
            >
              <div style={{ 
                display: 'flex', 
                alignItems: 'center', 
                cursor: 'pointer',
                padding: '0 12px',
                borderRadius: 6,
                transition: 'background-color 0.2s'
              }}>
                <Avatar 
                  src={user?.profilePictureUrl} 
                  icon={<UserOutlined />}
                  style={{ marginRight: 8 }}
                />
                <Text strong>{user?.name}</Text>
              </div>
            </Dropdown>
          </div>
        </Header>
        
        <Content className="main-content">
          {children}
        </Content>
      </Layout>
    </Layout>
  );
};

export default AppLayout;
