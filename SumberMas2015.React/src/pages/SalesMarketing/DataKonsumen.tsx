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
  Tag
} from 'antd';
import { 
  PlusOutlined, 
  SearchOutlined, 
  EditOutlined, 
  DeleteOutlined,
  ReloadOutlined
} from '@ant-design/icons';
import { useQuery, useMutation, useQueryClient } from 'react-query';
import { salesMarketingService } from '@/services/salesMarketingService';
import { DataKonsumen, JenisKelamin, Agama } from '@/types';
import { format } from 'date-fns';
import { id } from 'date-fns/locale';

const { Title } = Typography;
const { Search } = Input;
const { Option } = Select;
const { TextArea } = Input;

const DataKonsumenPage: React.FC = () => {
  const [form] = Form.useForm();
  const queryClient = useQueryClient();
  
  const [isModalVisible, setIsModalVisible] = useState(false);
  const [editingItem, setEditingItem] = useState<DataKonsumen | null>(null);
  const [searchText, setSearchText] = useState('');
  const [pagination, setPagination] = useState({
    current: 1,
    pageSize: 10,
    total: 0,
  });

  // Fetch konsumen data
  const { data, isLoading, refetch } = useQuery(
    ['konsumen', pagination.current, pagination.pageSize, searchText],
    () => salesMarketingService.getKonsumen(pagination.current, pagination.pageSize, searchText),
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
  const createMutation = useMutation(salesMarketingService.createKonsumen, {
    onSuccess: () => {
      message.success('Data konsumen berhasil ditambahkan!');
      setIsModalVisible(false);
      form.resetFields();
      queryClient.invalidateQueries(['konsumen']);
    },
    onError: (error: any) => {
      message.error(error.message || 'Gagal menambahkan data konsumen');
    },
  });

  // Update mutation
  const updateMutation = useMutation(
    ({ id, data }: { id: string; data: Partial<DataKonsumen> }) =>
      salesMarketingService.updateKonsumen(id, data),
    {
      onSuccess: () => {
        message.success('Data konsumen berhasil diperbarui!');
        setIsModalVisible(false);
        setEditingItem(null);
        form.resetFields();
        queryClient.invalidateQueries(['konsumen']);
      },
      onError: (error: any) => {
        message.error(error.message || 'Gagal memperbarui data konsumen');
      },
    }
  );

  // Delete mutation
  const deleteMutation = useMutation(salesMarketingService.deleteKonsumen, {
    onSuccess: () => {
      message.success('Data konsumen berhasil dihapus!');
      queryClient.invalidateQueries(['konsumen']);
    },
    onError: (error: any) => {
      message.error(error.message || 'Gagal menghapus data konsumen');
    },
  });

  const getJenisKelaminText = (value: number) => {
    return value === JenisKelamin.Pria ? 'Pria' : 'Wanita';
  };

  const getAgamaText = (value: number) => {
    const agamaMap = {
      [Agama.Islam]: 'Islam',
      [Agama.Kristen]: 'Kristen',
      [Agama.Katolik]: 'Katolik',
      [Agama.Hindu]: 'Hindu',
      [Agama.Buddha]: 'Buddha',
      [Agama.Konghucu]: 'Konghucu',
    };
    return agamaMap[value as Agama] || 'Tidak Diketahui';
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
      title: 'Nama Konsumen',
      dataIndex: 'namaKonsumen',
      key: 'namaKonsumen',
      sorter: true,
    },
    {
      title: 'Email',
      dataIndex: 'email',
      key: 'email',
    },
    {
      title: 'Telepon',
      dataIndex: 'telepon',
      key: 'telepon',
    },
    {
      title: 'Jenis Kelamin',
      dataIndex: 'jenisKelamin',
      key: 'jenisKelamin',
      width: 120,
      render: (value: number) => (
        <Tag color={value === JenisKelamin.Pria ? 'blue' : 'pink'}>
          {getJenisKelaminText(value)}
        </Tag>
      ),
    },
    {
      title: 'Agama',
      dataIndex: 'agama',
      key: 'agama',
      width: 100,
      render: (value: number) => getAgamaText(value),
    },
    {
      title: 'Bidang Pekerjaan',
      dataIndex: 'bidangPekerjaan',
      key: 'bidangPekerjaan',
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
      render: (_: any, record: DataKonsumen) => (
        <Space size="small">
          <Button
            type="primary"
            size="small"
            icon={<EditOutlined />}
            onClick={() => handleEdit(record)}
          />
          <Popconfirm
            title="Apakah Anda yakin ingin menghapus konsumen ini?"
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
  };

  const handleEdit = (item: DataKonsumen) => {
    setEditingItem(item);
    setIsModalVisible(true);
    form.setFieldsValue(item);
  };

  const handleSubmit = async (values: any) => {
    if (editingItem) {
      updateMutation.mutate({ id: editingItem.id, data: values });
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
          Data Konsumen
        </Title>
      </div>

      {/* Action Bar */}
      <Card style={{ marginBottom: 16 }}>
        <Row justify="space-between" align="middle">
          <Col>
            <Space>
              <Search
                placeholder="Cari konsumen..."
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
              Tambah Konsumen
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
          scroll={{ x: 1000 }}
        />
      </Card>

      {/* Modal Form */}
      <Modal
        title={editingItem ? 'Edit Data Konsumen' : 'Tambah Data Konsumen'}
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
                name="namaKonsumen"
                label="Nama Konsumen"
                rules={[{ required: true, message: 'Nama konsumen wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nama konsumen" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="email"
                label="Email"
                rules={[
                  { required: true, message: 'Email wajib diisi!' },
                  { type: 'email', message: 'Format email tidak valid!' }
                ]}
              >
                <Input placeholder="Masukkan email" />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="telepon"
                label="Telepon"
                rules={[{ required: true, message: 'Nomor telepon wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nomor telepon" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="jenisKelamin"
                label="Jenis Kelamin"
                rules={[{ required: true, message: 'Jenis kelamin wajib dipilih!' }]}
              >
                <Select placeholder="Pilih jenis kelamin">
                  <Option value={JenisKelamin.Pria}>Pria</Option>
                  <Option value={JenisKelamin.Wanita}>Wanita</Option>
                </Select>
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="agama"
                label="Agama"
                rules={[{ required: true, message: 'Agama wajib dipilih!' }]}
              >
                <Select placeholder="Pilih agama">
                  <Option value={Agama.Islam}>Islam</Option>
                  <Option value={Agama.Kristen}>Kristen</Option>
                  <Option value={Agama.Katolik}>Katolik</Option>
                  <Option value={Agama.Hindu}>Hindu</Option>
                  <Option value={Agama.Buddha}>Buddha</Option>
                  <Option value={Agama.Konghucu}>Konghucu</Option>
                </Select>
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="bidangPekerjaan"
                label="Bidang Pekerjaan"
                rules={[{ required: true, message: 'Bidang pekerjaan wajib diisi!' }]}
              >
                <Input placeholder="Masukkan bidang pekerjaan" />
              </Form.Item>
            </Col>
          </Row>

          <Form.Item
            name="alamat"
            label="Alamat"
            rules={[{ required: true, message: 'Alamat wajib diisi!' }]}
          >
            <TextArea
              rows={3}
              placeholder="Masukkan alamat lengkap"
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

export default DataKonsumenPage;
