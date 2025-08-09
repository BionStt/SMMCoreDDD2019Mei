import React, { useState } from 'react';
import { 
  Card, 
  Table, 
  Button, 
  Space, 
  Input, 
  Modal, 
  Form, 
  Typography, 
  Select,
  message,
  Popconfirm,
  Row,
  Col,
  Tag,
  DatePicker,
  InputNumber
} from 'antd';
import { 
  PlusOutlined, 
  SearchOutlined, 
  EditOutlined, 
  DeleteOutlined,
  ReloadOutlined,
  FileTextOutlined
} from '@ant-design/icons';
import { useQuery, useMutation, useQueryClient } from 'react-query';
import { salesMarketingService } from '@/services/salesMarketingService';
import { inventoryService } from '@/services/inventoryService';
import { DataSPK, StatusInputSPK } from '@/types';
import { format } from 'date-fns';
import { id } from 'date-fns/locale';
import dayjs from 'dayjs';

const { Title } = Typography;
const { Search } = Input;
const { Option } = Select;

const DataSPKPage: React.FC = () => {
  const [form] = Form.useForm();
  const queryClient = useQueryClient();
  
  const [isModalVisible, setIsModalVisible] = useState(false);
  const [editingItem, setEditingItem] = useState<DataSPK | null>(null);
  const [searchText, setSearchText] = useState('');
  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 10,
    total: 0,
  });

  // Fetch SPK data
  const { data, isLoading, refetch } = useQuery(
    ['spk', pagination.current, pagination.pageSize, searchText],
    () => salesMarketingService.getSPK(pagination.current, pagination.pageSize, searchText),
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

  // Fetch konsumen for dropdown
  const { data: konsumenData } = useQuery(
    ['konsumen-all'],
    () => salesMarketingService.getKonsumen(1, 1000),
    {
      staleTime: 5 * 60 * 1000, // 5 minutes
    }
  );

  // Fetch master barang for dropdown
  const { data: masterBarangData } = useQuery(
    ['master-barang-all'],
    () => inventoryService.getMasterBarang(1, 1000),
    {
      staleTime: 5 * 60 * 1000, // 5 minutes
    }
  );

  // Create mutation
  const createMutation = useMutation(salesMarketingService.createSPK, {
    onSuccess: () => {
      message.success('Data SPK berhasil ditambahkan!');
      setIsModalVisible(false);
      form.resetFields();
      queryClient.invalidateQueries(['spk']);
    },
    onError: (error: any) => {
      message.error(error.message || 'Gagal menambahkan data SPK');
    },
  });

  // Update mutation
  const updateMutation = useMutation(
    ({ id, data }: { id: string; data: Partial<DataSPK> }) =>
      salesMarketingService.updateSPK(id, data),
    {
      onSuccess: () => {
        message.success('Data SPK berhasil diperbarui!');
        setIsModalVisible(false);
        setEditingItem(null);
        form.resetFields();
        queryClient.invalidateQueries(['spk']);
      },
      onError: (error: any) => {
        message.error(error.message || 'Gagal memperbarui data SPK');
      },
    }
  );

  // Delete mutation
  const deleteMutation = useMutation(salesMarketingService.deleteSPK, {
    onSuccess: () => {
      message.success('Data SPK berhasil dihapus!');
      queryClient.invalidateQueries(['spk']);
    },
    onError: (error: any) => {
      message.error(error.message || 'Gagal menghapus data SPK');
    },
  });

  const getStatusColor = (status: number) => {
    const statusColors = {
      [StatusInputSPK.Draft]: 'default',
      [StatusInputSPK.Submitted]: 'processing',
      [StatusInputSPK.Approved]: 'success',
      [StatusInputSPK.Rejected]: 'error',
    };
    return statusColors[status as StatusInputSPK] || 'default';
  };

  const getStatusText = (status: number) => {
    const statusTexts = {
      [StatusInputSPK.Draft]: 'Draft',
      [StatusInputSPK.Submitted]: 'Diajukan',
      [StatusInputSPK.Approved]: 'Disetujui',
      [StatusInputSPK.Rejected]: 'Ditolak',
    };
    return statusTexts[status as StatusInputSPK] || 'Tidak Diketahui';
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
      title: 'Nomor SPK',
      dataIndex: 'nomorSPK',
      key: 'nomorSPK',
      sorter: true,
    },
    {
      title: 'Tanggal SPK',
      dataIndex: 'tanggalSPK',
      key: 'tanggalSPK',
      width: 120,
      render: (date: string) => format(new Date(date), 'dd/MM/yyyy', { locale: id }),
    },
    {
      title: 'Nama Konsumen',
      dataIndex: 'namaKonsumen',
      key: 'namaKonsumen',
    },
    {
      title: 'Nama Barang',
      dataIndex: 'namaBarang',
      key: 'namaBarang',
    },
    {
      title: 'Harga Jual',
      dataIndex: 'hargaJual',
      key: 'hargaJual',
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
      dataIndex: 'statusInputSPK',
      key: 'statusInputSPK',
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
      width: 120,
      render: (_: any, record: DataSPK) => (
        <Space size="small">
          <Button
            type="primary"
            size="small"
            icon={<EditOutlined />}
            onClick={() => handleEdit(record)}
          />
          <Popconfirm
            title="Apakah Anda yakin ingin menghapus SPK ini?"
            onConfirm={() => deleteMutation.mutate(record.id)}
            okText="Ya"
            cancelText="Tidak"
          >
            <Button
              type="primary"
              danger
              size="small"
              icon={<DeleteOutlined />}
              loading={deleteMutation.isLoading}
            />
          </Popconfirm>
        </Space>
      ),
    },
  ];

  const handleAdd = () => {
    setEditingItem(null);
    setIsModalVisible(true);
    form.resetFields();
    // Set default values
    form.setFieldsValue({
      tanggalSPK: dayjs(),
      statusInputSPK: StatusInputSPK.Draft,
    });
  };

  const handleEdit = (item: DataSPK) => {
    setEditingItem(item);
    setIsModalVisible(true);
    form.setFieldsValue({
      ...item,
      tanggalSPK: dayjs(item.tanggalSPK),
    });
  };

  const handleSubmit = async (values: any) => {
    const submitData = {
      ...values,
      tanggalSPK: values.tanggalSPK.format('YYYY-MM-DD'),
    };
    
    if (editingItem) {
      updateMutation.mutate({ id: editingItem.id, data: submitData });
    } else {
      createMutation.mutate(submitData);
    }
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

  const isSubmitting = createMutation.isLoading || updateMutation.isLoading;

  return (
    <div>
      {/* Header */}
      <div className="page-header">
        <Title level={2} style={{ margin: 0 }}>
          Data SPK (Surat Pesanan Kendaraan)
        </Title>
      </div>

      {/* Action Bar */}
      <Card style={{ marginBottom: 16 }}>
        <Row justify="space-between" align="middle">
          <Col>
            <Space>
              <Search
                placeholder="Cari SPK..."
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
          <Col>
            <Button
              type="primary"
              icon={<PlusOutlined />}
              onClick={handleAdd}
            >
              Tambah SPK
            </Button>
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
          scroll={{ x: 1200 }}
        />
      </Card>

      {/* Modal Form */}
      <Modal
        title={
          <Space>
            <FileTextOutlined />
            {editingItem ? 'Edit Data SPK' : 'Tambah Data SPK'}
          </Space>
        }
        open={isModalVisible}
        onCancel={() => {
          setIsModalVisible(false);
          setEditingItem(null);
          form.resetFields();
        }}
        footer={null}
        width={800}
      >
        <Form
          form={form}
          layout="vertical"
          onFinish={handleSubmit}
          disabled={isSubmitting}
        >
          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="nomorSPK"
                label="Nomor SPK"
                rules={[{ required: true, message: 'Nomor SPK wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nomor SPK" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="tanggalSPK"
                label="Tanggal SPK"
                rules={[{ required: true, message: 'Tanggal SPK wajib diisi!' }]}
              >
                <DatePicker 
                  style={{ width: '100%' }}
                  format="DD/MM/YYYY"
                  placeholder="Pilih tanggal SPK"
                />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="konsumenId"
                label="Konsumen"
                rules={[{ required: true, message: 'Konsumen wajib dipilih!' }]}
              >
                <Select
                  placeholder="Pilih konsumen"
                  showSearch
                  optionFilterProp="children"
                  filterOption={(input, option) =>
                    (option?.children as unknown as string)
                      ?.toLowerCase()
                      .includes(input.toLowerCase())
                  }
                >
                  {konsumenData?.data.map((konsumen) => (
                    <Option key={konsumen.id} value={konsumen.id}>
                      {konsumen.namaKonsumen}
                    </Option>
                  ))}
                </Select>
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="masterBarangId"
                label="Master Barang"
                rules={[{ required: true, message: 'Master barang wajib dipilih!' }]}
              >
                <Select
                  placeholder="Pilih master barang"
                  showSearch
                  optionFilterProp="children"
                  filterOption={(input, option) =>
                    (option?.children as unknown as string)
                      ?.toLowerCase()
                      .includes(input.toLowerCase())
                  }
                >
                  {masterBarangData?.data.map((barang) => (
                    <Option key={barang.masterBarangId} value={barang.masterBarangId}>
                      {barang.namaBarang} - {barang.merek}
                    </Option>
                  ))}
                </Select>
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="hargaJual"
                label="Harga Jual"
                rules={[{ required: true, message: 'Harga jual wajib diisi!' }]}
              >
                <InputNumber
                  style={{ width: '100%' }}
                  placeholder="Masukkan harga jual"
                  formatter={value => `Rp ${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')}
                  parser={value => value!.replace(/Rp\s?|(,*)/g, '')}
                  min={0}
                />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="statusInputSPK"
                label="Status SPK"
                rules={[{ required: true, message: 'Status SPK wajib dipilih!' }]}
              >
                <Select placeholder="Pilih status SPK">
                  <Option value={StatusInputSPK.Draft}>Draft</Option>
                  <Option value={StatusInputSPK.Submitted}>Diajukan</Option>
                  <Option value={StatusInputSPK.Approved}>Disetujui</Option>
                  <Option value={StatusInputSPK.Rejected}>Ditolak</Option>
                </Select>
              </Form.Item>
            </Col>
          </Row>

          <div className="form-actions">
            <Space>
              <Button onClick={() => setIsModalVisible(false)}>
                Batal
              </Button>
              <Button
                type="primary"
                htmlType="submit"
                loading={isSubmitting}
              >
                {editingItem ? 'Perbarui' : 'Simpan'}
              </Button>
            </Space>
          </div>
        </Form>
      </Modal>
    </div>
  );
};

export default DataSPKPage;
