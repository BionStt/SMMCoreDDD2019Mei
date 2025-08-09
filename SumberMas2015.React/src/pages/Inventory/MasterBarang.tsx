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
  Tag,
  message,
  Popconfirm,
  Row,
  Col,
  InputNumber
} from 'antd';
import { 
  PlusOutlined, 
  SearchOutlined, 
  EditOutlined, 
  DeleteOutlined,
  ReloadOutlined
} from '@ant-design/icons';
import { useQuery, useMutation, useQueryClient } from 'react-query';
import { inventoryService } from '@/services/inventoryService';
import { MasterBarang, CreateMasterBarangRequest, MasterBarangStatus } from '@/types';

const { Title } = Typography;
const { Search } = Input;

const MasterBarangPage: React.FC = () => {
  const [form] = Form.useForm();
  const queryClient = useQueryClient();
  
  const [isModalVisible, setIsModalVisible] = useState(false);
  const [editingItem, setEditingItem] = useState<MasterBarang | null>(null);
  const [searchText, setSearchText] = useState('');
  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 10,
    total: 0,
  });

  // Fetch master barang data
  const { data, isLoading, refetch } = useQuery(
    ['masterBarang', pagination.current, pagination.pageSize, searchText],
    () => inventoryService.getMasterBarang(pagination.current, pagination.pageSize, searchText),
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

  // Create mutation
  const createMutation = useMutation(inventoryService.createMasterBarang, {
    onSuccess: () => {
      message.success('Master barang berhasil ditambahkan!');
      setIsModalVisible(false);
      form.resetFields();
      queryClient.invalidateQueries(['masterBarang']);
    },
    onError: (error: any) => {
      message.error(error.message || 'Gagal menambahkan master barang');
    },
  });

  // Update mutation
  const updateMutation = useMutation(
    ({ id, data }: { id: string; data: Partial<CreateMasterBarangRequest> }) =>
      inventoryService.updateMasterBarang(id, data),
    {
      onSuccess: () => {
        message.success('Master barang berhasil diperbarui!');
        setIsModalVisible(false);
        setEditingItem(null);
        form.resetFields();
        queryClient.invalidateQueries(['masterBarang']);
      },
      onError: (error: any) => {
        message.error(error.message || 'Gagal memperbarui master barang');
      },
    }
  );

  // Delete mutation
  const deleteMutation = useMutation(inventoryService.deleteMasterBarang, {
    onSuccess: () => {
      message.success('Master barang berhasil dihapus!');
      queryClient.invalidateQueries(['masterBarang']);
    },
    onError: (error: any) => {
      message.error(error.message || 'Gagal menghapus master barang');
    },
  });

  const columns = [
    {
      title: 'No',
      key: 'index',
      width: 60,
      render: (_: any, __: any, index: number) => 
        (pagination.current - 1) * pagination.pageSize + index + 1,
    },
    {
      title: 'Nama Barang',
      dataIndex: 'namaBarang',
      key: 'namaBarang',
      sorter: true,
    },
    {
      title: 'Nomor Rangka',
      dataIndex: 'nomorRangka',
      key: 'nomorRangka',
    },
    {
      title: 'Nomor Mesin',
      dataIndex: 'nomorMesin',
      key: 'nomorMesin',
    },
    {
      title: 'Merek',
      dataIndex: 'merek',
      key: 'merek',
    },
    {
      title: 'Type Kendaraan',
      dataIndex: 'typeKendaraan',
      key: 'typeKendaraan',
    },
    {
      title: 'Tahun',
      dataIndex: 'tahunPerakitan',
      key: 'tahunPerakitan',
      width: 80,
    },
    {
      title: 'Status',
      dataIndex: 'masterBarangStatus',
      key: 'masterBarangStatus',
      width: 100,
      render: (status: number) => (
        <Tag color={status === MasterBarangStatus.Aktif ? 'green' : 'red'}>
          {status === MasterBarangStatus.Aktif ? 'Aktif' : 'Tidak Aktif'}
        </Tag>
      ),
    },
    {
      title: 'Aksi',
      key: 'action',
      width: 120,
      render: (_: any, record: MasterBarang) => (
        <Space size="small">
          <Button
            type="primary"
            size="small"
            icon={<EditOutlined />}
            onClick={() => handleEdit(record)}
          />
          <Popconfirm
            title="Apakah Anda yakin ingin menghapus item ini?"
            onConfirm={() => deleteMutation.mutate(record.masterBarangId)}
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
  };

  const handleEdit = (item: MasterBarang) => {
    setEditingItem(item);
    setIsModalVisible(true);
    form.setFieldsValue(item);
  };

  const handleSubmit = async (values: CreateMasterBarangRequest) => {
    if (editingItem) {
      updateMutation.mutate({ id: editingItem.masterBarangId, data: values });
    } else {
      createMutation.mutate(values);
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
          Master Barang
        </Title>
      </div>

      {/* Action Bar */}
      <Card style={{ marginBottom: 16 }}>
        <Row justify="space-between" align="middle">
          <Col>
            <Space>
              <Search
                placeholder="Cari master barang..."
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
              Tambah Master Barang
            </Button>
          </Col>
        </Row>
      </Card>

      {/* Table */}
      <Card className="content-card">
        <Table
          columns={columns}
          dataSource={data?.data || []}
          rowKey="masterBarangId"
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
          scroll={{ x: 800 }}
        />
      </Card>

      {/* Modal Form */}
      <Modal
        title={editingItem ? 'Edit Master Barang' : 'Tambah Master Barang'}
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
                name="namaBarang"
                label="Nama Barang"
                rules={[{ required: true, message: 'Nama barang wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nama barang" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="merek"
                label="Merek"
                rules={[{ required: true, message: 'Merek wajib diisi!' }]}
              >
                <Input placeholder="Masukkan merek" />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="nomorRangka"
                label="Nomor Rangka"
                rules={[{ required: true, message: 'Nomor rangka wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nomor rangka" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="nomorMesin"
                label="Nomor Mesin"
                rules={[{ required: true, message: 'Nomor mesin wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nomor mesin" />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="typeKendaraan"
                label="Type Kendaraan"
                rules={[{ required: true, message: 'Type kendaraan wajib diisi!' }]}
              >
                <Input placeholder="Masukkan type kendaraan" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="tahunPerakitan"
                label="Tahun Perakitan"
                rules={[{ required: true, message: 'Tahun perakitan wajib diisi!' }]}
              >
                <Input placeholder="Masukkan tahun perakitan" />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="kapasitasMesin"
                label="Kapasitas Mesin"
              >
                <Input placeholder="Masukkan kapasitas mesin" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="hargaOff"
                label="Harga Off The Road"
              >
                <InputNumber
                  style={{ width: '100%' }}
                  placeholder="Masukkan harga OTR"
                  formatter={value => `Rp ${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')}
                  parser={value => value!.replace(/Rp\s?|(,*)/g, '')}
                />
              </Form.Item>
            </Col>
          </Row>

          <Form.Item
            name="bbn"
            label="BBN (Bea Balik Nama)"
          >
            <InputNumber
              style={{ width: '100%' }}
              placeholder="Masukkan BBN"
              formatter={value => `Rp ${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')}
              parser={value => value!.replace(/Rp\s?|(,*)/g, '')}
            />
          </Form.Item>

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

export default MasterBarangPage;
