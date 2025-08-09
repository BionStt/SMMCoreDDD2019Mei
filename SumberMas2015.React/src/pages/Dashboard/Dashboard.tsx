import React from 'react';
import { Card, Row, Col, Statistic, Typography, Space, Button } from 'antd';
import {
  ShoppingCartOutlined,
  InboxOutlined,
  TeamOutlined,
  BankOutlined,
  TrendingUpOutlined,
  DollarOutlined,
} from '@ant-design/icons';
import { useNavigate } from 'react-router-dom';
import { useAuthStore } from '@/store/authStore';

const { Title, Text } = Typography;

const Dashboard: React.FC = () => {
  const navigate = useNavigate();
  const { user } = useAuthStore();

  const statisticCards = [
    {
      title: 'Total Penjualan',
      value: 1234567890,
      prefix: 'Rp',
      icon: <DollarOutlined style={{ fontSize: 24, color: '#52c41a' }} />,
      color: '#52c41a',
    },
    {
      title: 'Total Konsumen',
      value: 1234,
      icon: <TeamOutlined style={{ fontSize: 24, color: '#1890ff' }} />,
      color: '#1890ff',
    },
    {
      title: 'Master Barang',
      value: 567,
      icon: <InboxOutlined style={{ fontSize: 24, color: '#722ed1' }} />,
      color: '#722ed1',
    },
    {
      title: 'SPK Aktif',
      value: 89,
      icon: <ShoppingCartOutlined style={{ fontSize: 24, color: '#fa8c16' }} />,
      color: '#fa8c16',
    },
  ];

  const quickActions = [
    {
      title: 'Tambah Konsumen Baru',
      description: 'Daftarkan konsumen baru ke sistem',
      action: () => navigate('/sales-marketing/konsumen'),
      icon: <TeamOutlined />,
    },
    {
      title: 'Buat SPK Baru',
      description: 'Buat Surat Pesanan Kendaraan baru',
      action: () => navigate('/sales-marketing/spk'),
      icon: <ShoppingCartOutlined />,
    },
    {
      title: 'Kelola Master Barang',
      description: 'Tambah atau edit master barang',
      action: () => navigate('/inventory/master-barang'),
      icon: <InboxOutlined />,
    },
    {
      title: 'Data Perusahaan',
      description: 'Kelola informasi perusahaan',
      action: () => navigate('/organization/perusahaan'),
      icon: <BankOutlined />,
    },
  ];

  return (
    <div>
      {/* Header */}
      <div className="page-header">
        <Title level={2} style={{ margin: 0 }}>
          Dashboard
        </Title>
        <Text type="secondary">
          Selamat datang kembali, {user?.name}! Berikut adalah ringkasan sistem ERP SumberMas.
        </Text>
      </div>

      {/* Statistics Cards */}
      <Row gutter={[16, 16]} style={{ marginBottom: 24 }}>
        {statisticCards.map((stat, index) => (
          <Col xs={24} sm={12} lg={6} key={index}>
            <Card className="content-card">
              <Statistic
                title={stat.title}
                value={stat.value}
                prefix={stat.prefix}
                valueStyle={{ color: stat.color }}
                suffix={
                  <div style={{ display: 'inline-block', marginLeft: 8 }}>
                    {stat.icon}
                  </div>
                }
              />
            </Card>
          </Col>
        ))}
      </Row>

      {/* Quick Actions */}
      <Card title="Aksi Cepat" className="content-card" style={{ marginBottom: 24 }}>
        <Row gutter={[16, 16]}>
          {quickActions.map((action, index) => (
            <Col xs={24} sm={12} lg={6} key={index}>
              <Card 
                hoverable
                style={{ height: '100%' }}
                onClick={action.action}
              >
                <Space direction="vertical" size="middle" style={{ width: '100%' }}>
                  <div style={{ fontSize: 32, color: '#1890ff', textAlign: 'center' }}>
                    {action.icon}
                  </div>
                  <div style={{ textAlign: 'center' }}>
                    <Title level={5} style={{ margin: 0 }}>
                      {action.title}
                    </Title>
                    <Text type="secondary" style={{ fontSize: 12 }}>
                      {action.description}
                    </Text>
                  </div>
                </Space>
              </Card>
            </Col>
          ))}
        </Row>
      </Card>

      {/* Recent Activities */}
      <Row gutter={[16, 16]}>
        <Col xs={24} lg={12}>
          <Card title="Aktivitas Terbaru" className="content-card">
            <Space direction="vertical" size="middle" style={{ width: '100%' }}>
              <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                <div>
                  <Text strong>SPK-2024-001</Text>
                  <br />
                  <Text type="secondary" style={{ fontSize: 12 }}>
                    SPK baru dibuat untuk Honda Civic
                  </Text>
                </div>
                <Text type="secondary" style={{ fontSize: 11 }}>
                  2 jam yang lalu
                </Text>
              </div>
              
              <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                <div>
                  <Text strong>Konsumen Baru</Text>
                  <br />
                  <Text type="secondary" style={{ fontSize: 12 }}>
                    John Doe terdaftar sebagai konsumen
                  </Text>
                </div>
                <Text type="secondary" style={{ fontSize: 11 }}>
                  4 jam yang lalu
                </Text>
              </div>
              
              <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                <div>
                  <Text strong>Master Barang</Text>
                  <br />
                  <Text type="secondary" style={{ fontSize: 12 }}>
                    Toyota Avanza 2024 ditambahkan
                  </Text>
                </div>
                <Text type="secondary" style={{ fontSize: 11 }}>
                  1 hari yang lalu
                </Text>
              </div>
            </Space>
          </Card>
        </Col>
        
        <Col xs={24} lg={12}>
          <Card title="Grafik Penjualan" className="content-card">
            <div style={{ 
              height: 200, 
              display: 'flex', 
              justifyContent: 'center', 
              alignItems: 'center',
              background: '#fafafa',
              borderRadius: 8
            }}>
              <Space direction="vertical" style={{ textAlign: 'center' }}>
                <TrendingUpOutlined style={{ fontSize: 48, color: '#bfbfbf' }} />
                <Text type="secondary">Grafik akan ditampilkan di sini</Text>
              </Space>
            </div>
          </Card>
        </Col>
      </Row>
    </div>
  );
};

export default Dashboard;
