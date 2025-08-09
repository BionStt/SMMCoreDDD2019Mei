import React, { useState } from 'react';
import { 
  Card, 
  Table, 
  Button, 
  Space, 
  Input, 
  Typography, 
  Tag,
  Row,
  Col,
  Statistic
} from 'antd';
import { 
  SearchOutlined, 
  EyeOutlined,
  ReloadOutlined,
  DollarOutlined,
  ShoppingCartOutlined
} from '@ant-design/icons';
import { useQuery } from 'react-query';
import { salesMarketingService } from '@/services/salesMarketingService';
import { DataPenjualan } from '@/types';
import { format } from 'date-fns';
import { id } from 'date-fns/locale';

const { Title } = Typography;
const { Search } = Input;

const DataPenjualanPage: React.FC = () => {
  const [searchText, setSearchText] = useState('');
  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 10,
    total: 0,
  });

  // Fetch penjualan data
  const { data, isLoading, refetch } = useQuery(
    ['penjualan', pagination.current, pagination.pageSize, searchText],
    () => salesMarketingService.getPenjualan(pagination.current, pagination.pageSize, searchText),
    {
      keepPreviousData: true,
      onSuccess: (data) => {
        setPagination(prev => ({
          ...prev,
          total: data.totalCount,
        }));
      },
    }
  );

  const getStatusColor = (status: number) => {
    const statusColors = {
      0: 'processing', // Draft
      1: 'warning',    // Pending
      2: 'success',    // Completed
      3: 'error',      // Cancelled
    };
    return statusColors[status as keyof typeof statusColors] || 'default';
  };

  const getStatusText = (status: number) => {
    const statusTexts = {
      0: 'Draft',
      1: 'Pending',
      2: 'Selesai',
      3: 'Dibatalkan',
    };
    return statusTexts[status as keyof typeof statusTexts] || 'Tidak Diketahui';
  };

  const formatCurrency = (amount: number) => {
    return new Intl.NumberFormat('id-ID', {
      style: 'currency',
      currency: 'IDR',
      minimumFractionDigits: 0,
    }).format(amount);
  };

  const columns = [
    {
      title: 'No',
      key: 'index',
      width: 60,
      render: (_: any, __: any, index: number) => 
        (pagination.current - 1) * pagination.pageSize + index + 1,
    },
    {
      title: 'Nomor Penjualan',
      dataIndex: 'nomorPenjualan',
      key: 'nomorPenjualan',
      sorter: true,
    },
    {
      title: 'Tanggal Penjualan',
      dataIndex: 'tanggalPenjualan',
      key: 'tanggalPenjualan',
      width: 130,
      render: (date: string) => format(new Date(date), 'dd/MM/yyyy', { locale: id }),
    },
    {
      title: 'Nama Konsumen',
      dataIndex: 'namaKonsumen',
      key: 'namaKonsumen',
    },
    {
      title: 'Total Harga',
      dataIndex: 'totalHarga',
      key: 'totalHarga',
      width: 150,
      align: 'right' as const,
      render: (amount: number) => (
        <span style={{ fontWeight: 'bold', color: '#52c41a' }}>
          {formatCurrency(amount)}
        </span>
      ),
    },
    {
      title: 'Status',
      dataIndex: 'status',
      key: 'status',
      width: 120,
      render: (status: number) => (
        <Tag color={getStatusColor(status)}>
          {getStatusText(status)}
        </Tag>
      ),
    },
    {
      title: 'Tanggal Dibuat',
      dataIndex: 'createdDate',
      key: 'createdDate',
      width: 120,
      render: (date: string) => format(new Date(date), 'dd/MM/yyyy', { locale: id }),
    },
    {
      title: 'Aksi',
      key: 'action',
      width: 80,
      render: (_: any, record: DataPenjualan) => (
        <Button
          type="primary"
          size="small"
          icon={<EyeOutlined />}
          onClick={() => handleView(record)}
        >
          Detail
        </Button>
      ),
    },
  ];

  const handleView = (item: DataPenjualan) => {
    // TODO: Implement view detail functionality
    console.log('View detail:', item);
  };

  const handleTableChange = (pagination: any) => {
    setPagination(prev => ({
      ...prev,
      current: pagination.current,
      pageSize: pagination.pageSize,
    }));
  };

  const handleSearch = (value: string) => {
    setSearchText(value);
    setPagination(prev => ({ ...prev, current: 1 }));
  };

  // Calculate statistics
  const totalPenjualan = data?.data.reduce((sum, item) => sum + item.totalHarga, 0) || 0;
  const countByStatus = data?.data.reduce((acc, item) => {
    acc[item.status] = (acc[item.status] || 0) + 1;
    return acc;
  }, {} as Record<number, number>) || {};

  return (
    <div>
      {/* Header */}
      <div className="page-header">
        <Title level={2} style={{ margin: 0 }}>
          Data Penjualan
        </Title>
      </div>

      {/* Statistics */}
      <Row gutter={[16, 16]} style={{ marginBottom: 24 }}>
        <Col xs={24} sm={8}>
          <Card>
            <Statistic
              title="Total Penjualan"
              value={totalPenjualan}
              formatter={(value) => formatCurrency(Number(value))}
              prefix={<DollarOutlined style={{ color: '#52c41a' }} />}
              valueStyle={{ color: '#52c41a' }}
            />
          </Card>
        </Col>
        <Col xs={24} sm={8}>
          <Card>
            <Statistic
              title="Total Transaksi"
              value={data?.totalCount || 0}
              prefix={<ShoppingCartOutlined style={{ color: '#1890ff' }} />}
              valueStyle={{ color: '#1890ff' }}
            />
          </Card>
        </Col>
        <Col xs={24} sm={8}>
          <Card>
            <Statistic
              title="Transaksi Selesai"
              value={countByStatus[2] || 0}
              suffix={`/ ${data?.totalCount || 0}`}
              valueStyle={{ color: '#722ed1' }}
            />
          </Card>
        </Col>
      </Row>

      {/* Action Bar */}
      <Card style={{ marginBottom: 16 }}>
        <Row justify="space-between" align="middle">
          <Col>
            <Space>
              <Search
                placeholder="Cari penjualan..."
                allowClear
                enterButton={<SearchOutlined />}
                onSearch={handleSearch}
                style={{ width: 300 }}
              />
              <Button
                icon={<ReloadOutlined />}
                onClick={() => refetch()}
                loading={isLoading}
              >
                Refresh
              </Button>
            </Space>
          </Col>
        </Row>
      </Card>

      {/* Table */}
      <Card className="content-card">
        <Table
          columns={columns}
          dataSource={data?.data || []}
          rowKey="id"
          loading={isLoading}
          pagination={{
            current: pagination.current,
            pageSize: pagination.pageSize,
            total: pagination.total,
            showSizeChanger: true,
            showQuickJumper: true,
            showTotal: (total, range) =>
              `${range[0]}-${range[1]} dari ${total} items`,
          }}
          onChange={handleTableChange}
          scroll={{ x: 1000 }}
          summary={(pageData) => {
            const totalPage = pageData.reduce((sum, item) => sum + item.totalHarga, 0);
            return (
              <Table.Summary.Row>
                <Table.Summary.Cell index={0} colSpan={4}>
                  <strong>Total Halaman Ini:</strong>
                </Table.Summary.Cell>
                <Table.Summary.Cell index={4} align="right">
                  <strong style={{ color: '#52c41a' }}>
                    {formatCurrency(totalPage)}
                  </strong>
                </Table.Summary.Cell>
                <Table.Summary.Cell index={5} colSpan={3} />
              </Table.Summary.Row>
            );
          }}
        />
      </Card>
    </div>
  );
};

export default DataPenjualanPage;
