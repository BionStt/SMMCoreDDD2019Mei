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
  DatePicker
} from 'antd';
import { 
  PlusOutlined, 
  SearchOutlined, 
  EditOutlined, 
  DeleteOutlined,
  ReloadOutlined,
  UserOutlined
} from '@ant-design/icons';
import { DataPegawai } from '@/types';
import { format } from 'date-fns';
import { id } from 'date-fns/locale';
import dayjs from 'dayjs';

const { Title } = Typography;
const { Search } = Input;
const { Option } = Select;

// Mock data - in real app, this would come from API
const mockData: DataPegawai[] = [
  {
    id: '1',
    namaPegawai: 'John Doe',
    nip: 'EMP001',
    jabatan: 'Manager Sales',
    departemen: 'Sales & Marketing',
    tanggalMasuk: '2023-01-15',
    status: 1,
    email: 'john.doe@sumbermas.com',
    telepon: '081234567890',
  },
  {
    id: '2',
    namaPegawai: 'Jane Smith',
    nip: 'EMP002',
    jabatan: 'Staff Inventory',
    departemen: 'Inventory',
    tanggalMasuk: '2023-02-20',
    status: 1,
    email: 'jane.smith@sumbermas.com',
    telepon: '081234567891',
  },
];

const DataPegawaiPage: React.FC = () => {
  const [form] = Form.useForm();
  
  const [isModalVisible, setIsModalVisible] = useState(false);
  const [editingItem, setEditingItem] = useState<DataPegawai | null>(null);
  const [searchText, setSearchText] = useState('');
  const [data, setData] = useState<DataPegawai[]>(mockData);
  const [isLoading, setIsLoading] = useState(false);

  const filteredData = data.filter(item =>
    item.namaPegawai.toLowerCase().includes(searchText.toLowerCase()) ||
    item.nip.toLowerCase().includes(searchText.toLowerCase()) ||
    item.jabatan.toLowerCase().includes(searchText.toLowerCase()) ||
    item.departemen.toLowerCase().includes(searchText.toLowerCase())
  );

  const getStatusColor = (status: number) => {
    return status === 1 ? 'green' : 'red';
  };

  const getStatusText = (status: number) => {
    return status === 1 ? 'Aktif' : 'Tidak Aktif';
  };

  const columns = [
    {
      title: 'No',
      key: 'index',
      width: 60,
      render: (_: any, __: any, index: number) => index + 1,
    },
    {
      title: 'NIP',
      dataIndex: 'nip',
      key: 'nip',
      width: 100,
    },
    {
      title: 'Nama Pegawai',
      dataIndex: 'namaPegawai',
      key: 'namaPegawai',
      sorter: (a: DataPegawai, b: DataPegawai) => 
        a.namaPegawai.localeCompare(b.namaPegawai),
    },
    {
      title: 'Jabatan',
      dataIndex: 'jabatan',
      key: 'jabatan',
    },
    {
      title: 'Departemen',
      dataIndex: 'departemen',
      key: 'departemen',
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
      width: 120,
    },
    {
      title: 'Tanggal Masuk',
      dataIndex: 'tanggalMasuk',
      key: 'tanggalMasuk',
      width: 120,
      render: (date: string) => format(new Date(date), 'dd/MM/yyyy', { locale: id }),
    },
    {
      title: 'Status',
      dataIndex: 'status',
      key: 'status',
      width: 100,
      render: (status: number) => (
        <Tag color={getStatusColor(status)}>
          {getStatusText(status)}
        </Tag>
      ),
    },
    {
      title: 'Aksi',
      key: 'action',
      width: 120,
      render: (_: any, record: DataPegawai) => (
        <Space size="small">
          <Button
            type="primary"
            size="small"
            icon={<EditOutlined />}
            onClick={() => handleEdit(record)}
          />
          <Popconfirm
            title="Apakah Anda yakin ingin menghapus data pegawai ini?"
            onConfirm={() => handleDelete(record.id)}
            okText="Ya"
            cancelText="Tidak"
          >
            <Button
              type="primary"
              danger
              size="small"
              icon={<DeleteOutlined />}
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
    form.setFieldsValue({
      status: 1,
      tanggalMasuk: dayjs(),
    });
  };

  const handleEdit = (item: DataPegawai) => {
    setEditingItem(item);
    setIsModalVisible(true);
    form.setFieldsValue({
      ...item,
      tanggalMasuk: dayjs(item.tanggalMasuk),
    });
  };

  const handleDelete = (id: string) => {
    setData(prev => prev.filter(item => item.id !== id));
    message.success('Data pegawai berhasil dihapus!');
  };

  const handleSubmit = async (values: any) => {
    const submitData = {
      ...values,
      tanggalMasuk: values.tanggalMasuk.format('YYYY-MM-DD'),
    };
    
    if (editingItem) {
      // Update
      setData(prev => prev.map(item => 
        item.id === editingItem.id 
          ? { ...item, ...submitData }
          : item
      ));
      message.success('Data pegawai berhasil diperbarui!');
    } else {
      // Create
      const newItem: DataPegawai = {
        ...submitData,
        id: Date.now().toString(),
      };
      setData(prev => [...prev, newItem]);
      message.success('Data pegawai berhasil ditambahkan!');
    }
    
    setIsModalVisible(false);
    setEditingItem(null);
    form.resetFields();
  };

  const handleSearch = (value: string) => {
    setSearchText(value);
  };

  return (
    <div>
      {/* Header */}
      <div className="page-header">
        <Title level={2} style={{ margin: 0 }}>
          Data Pegawai
        </Title>
      </div>

      {/* Action Bar */}
      <Card style={{ marginBottom: 16 }}>
        <Row justify="space-between" align="middle">
          <Col>
            <Space>
              <Search
                placeholder="Cari data pegawai..."
                allowClear
                enterButton={<SearchOutlined />}
                onSearch={handleSearch}
                style={{ width: 300 }}
              />
              <Button
                icon={<ReloadOutlined />}
                onClick={() => setData(mockData)}
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
              Tambah Pegawai
            </Button>
          </Col>
        </Row>
      </Card>

      {/* Table */}
      <Card className="content-card">
        <Table
          columns={columns}
          dataSource={filteredData}
          rowKey="id"
          loading={isLoading}
          pagination={{
            showSizeChanger: true,
            showQuickJumper: true,
            showTotal: (total, range) =>
              `${range[0]}-${range[1]} dari ${total} items`,
          }}
          scroll={{ x: 1200 }}
        />
      </Card>

      {/* Modal Form */}
      <Modal
        title={
          <Space>
            <UserOutlined />
            {editingItem ? 'Edit Data Pegawai' : 'Tambah Data Pegawai'}
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
        >
          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="nip"
                label="NIP"
                rules={[{ required: true, message: 'NIP wajib diisi!' }]}
              >
                <Input placeholder="Masukkan NIP" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="namaPegawai"
                label="Nama Pegawai"
                rules={[{ required: true, message: 'Nama pegawai wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nama pegawai" />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="jabatan"
                label="Jabatan"
                rules={[{ required: true, message: 'Jabatan wajib diisi!' }]}
              >
                <Input placeholder="Masukkan jabatan" />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="departemen"
                label="Departemen"
                rules={[{ required: true, message: 'Departemen wajib diisi!' }]}
              >
                <Select placeholder="Pilih departemen">
                  <Option value="Sales & Marketing">Sales & Marketing</Option>
                  <Option value="Inventory">Inventory</Option>
                  <Option value="Human Capital">Human Capital</Option>
                  <Option value="Finance & Accounting">Finance & Accounting</Option>
                  <Option value="IT">IT</Option>
                  <Option value="General Affairs">General Affairs</Option>
                </Select>
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
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
            <Col span={12}>
              <Form.Item
                name="telepon"
                label="Telepon"
                rules={[{ required: true, message: 'Nomor telepon wajib diisi!' }]}
              >
                <Input placeholder="Masukkan nomor telepon" />
              </Form.Item>
            </Col>
          </Row>

          <Row gutter={16}>
            <Col span={12}>
              <Form.Item
                name="tanggalMasuk"
                label="Tanggal Masuk"
                rules={[{ required: true, message: 'Tanggal masuk wajib diisi!' }]}
              >
                <DatePicker 
                  style={{ width: '100%' }}
                  format="DD/MM/YYYY"
                  placeholder="Pilih tanggal masuk"
                />
              </Form.Item>
            </Col>
            <Col span={12}>
              <Form.Item
                name="status"
                label="Status"
                rules={[{ required: true, message: 'Status wajib dipilih!' }]}
              >
                <Select placeholder="Pilih status">
                  <Option value={1}>Aktif</Option>
                  <Option value={0}>Tidak Aktif</Option>
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

export default DataPegawaiPage;
