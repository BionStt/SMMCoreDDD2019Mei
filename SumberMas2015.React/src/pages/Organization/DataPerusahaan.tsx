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
  message,
  Popconfirm,
  Row,
  Col
} from 'antd';
import { 
  PlusOutlined, 
  SearchOutlined, 
  EditOutlined, 
  DeleteOutlined,
  ReloadOutlined,
  BankOutlined
} from '@ant-design/icons';
import { DataPerusahaan } from '@/types';
import { format } from 'date-fns';
import { id } from 'date-fns/locale';

const { Title } = Typography;
const { Search } = Input;
const { TextArea } = Input;

// Mock data - in real app, this would come from API
const mockData: DataPerusahaan[] = [
  {
    dataPerusahaanId: '1',
    namaPerusahaan: 'PT Sumber Mas Motor',
    alamatPerusahaan: 'Jl. Raya Veteran No. 123, Jakarta Selatan',
    penanggungJawab: 'John Doe',
    createdDate: '2024-01-01',
  },
];

const DataPerusahaanPage: React.FC = () => {
  const [form] = Form.useForm();
  
  const [isModalVisible, setIsModalVisible] = useState(false);
  const [editingItem, setEditingItem] = useState<DataPerusahaan | null>(null);
  const [searchText, setSearchText] = useState('');
  const [data, setData] = useState<DataPerusahaan[]>(mockData);
  const [isLoading, setIsLoading] = useState(false);

  const filteredData = data.filter(item =>
    item.namaPerusahaan.toLowerCase().includes(searchText.toLowerCase()) ||
    item.penanggungJawab.toLowerCase().includes(searchText.toLowerCase())
  );

  const columns = [
    {
      title: 'No',
      key: 'index',
      width: 60,
      render: (_: any, __: any, index: number) => index + 1,
    },
    {
      title: 'Nama Perusahaan',
      dataIndex: 'namaPerusahaan',
      key: 'namaPerusahaan',
      sorter: (a: DataPerusahaan, b: DataPerusahaan) => 
        a.namaPerusahaan.localeCompare(b.namaPerusahaan),
    },
    {
      title: 'Alamat Perusahaan',
      dataIndex: 'alamatPerusahaan',
      key: 'alamatPerusahaan',
    },
    {
      title: 'Penanggung Jawab',
      dataIndex: 'penanggungJawab',
      key: 'penanggungJawab',
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
      render: (_: any, record: DataPerusahaan) => (
        <Space size="small">
          <Button
            type="primary"
            size="small"
            icon={<EditOutlined />}
            onClick={() => handleEdit(record)}
          />
          <Popconfirm
            title="Apakah Anda yakin ingin menghapus data perusahaan ini?"
            onConfirm={() => handleDelete(record.dataPerusahaanId)}
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
  };

  const handleEdit = (item: DataPerusahaan) => {
    setEditingItem(item);
    setIsModalVisible(true);
    form.setFieldsValue(item);
  };

  const handleDelete = (id: string) => {
    setData(prev => prev.filter(item => item.dataPerusahaanId !== id));
    message.success('Data perusahaan berhasil dihapus!');
  };

  const handleSubmit = async (values: any) => {
    if (editingItem) {
      // Update
      setData(prev => prev.map(item => 
        item.dataPerusahaanId === editingItem.dataPerusahaanId 
          ? { ...item, ...values, updatedDate: new Date().toISOString() }
          : item
      ));
      message.success('Data perusahaan berhasil diperbarui!');
    } else {
      // Create
      const newItem: DataPerusahaan = {
        ...values,
        dataPerusahaanId: Date.now().toString(),
        createdDate: new Date().toISOString(),
      };
      setData(prev => [...prev, newItem]);
      message.success('Data perusahaan berhasil ditambahkan!');
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
          Data Perusahaan
        </Title>
      </div>

      {/* Action Bar */}
      <Card style={{ marginBottom: 16 }}>
        <Row justify="space-between" align="middle">
          <Col>
            <Space>
              <Search
                placeholder="Cari data perusahaan..."
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
              Tambah Data Perusahaan
            </Button>
          </Col>
        </Row>
      </Card>

      {/* Table */}
      <Card className="content-card">
        <Table
          columns={columns}
          dataSource={filteredData}
          rowKey="dataPerusahaanId"
          loading={isLoading}
          pagination={{
            showSizeChanger: true,
            showQuickJumper: true,
            showTotal: (total, range) =>
              `${range[0]}-${range[1]} dari ${total} items`,
          }}
          scroll={{ x: 800 }}
        />
      </Card>

      {/* Modal Form */}
      <Modal
        title={
          <Space>
            <BankOutlined />
            {editingItem ? 'Edit Data Perusahaan' : 'Tambah Data Perusahaan'}
          </Space>
        }
        open={isModalVisible}
        onCancel={() => {
          setIsModalVisible(false);
          setEditingItem(null);
          form.resetFields();
        }}
        footer={null}
        width={600}
      >
        <Form
          form={form}
          layout="vertical"
          onFinish={handleSubmit}
        >
          <Form.Item
            name="namaPerusahaan"
            label="Nama Perusahaan"
            rules={[{ required: true, message: 'Nama perusahaan wajib diisi!' }]}
          >
            <Input placeholder="Masukkan nama perusahaan" />
          </Form.Item>

          <Form.Item
            name="alamatPerusahaan"
            label="Alamat Perusahaan"
            rules={[{ required: true, message: 'Alamat perusahaan wajib diisi!' }]}
          >
            <TextArea
              rows={3}
              placeholder="Masukkan alamat lengkap perusahaan"
            />
          </Form.Item>

          <Form.Item
            name="penanggungJawab"
            label="Penanggung Jawab"
            rules={[{ required: true, message: 'Penanggung jawab wajib diisi!' }]}
          >
            <Input placeholder="Masukkan nama penanggung jawab" />
          </Form.Item>

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

export default DataPerusahaanPage;
