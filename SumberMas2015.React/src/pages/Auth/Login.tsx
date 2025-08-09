import React, { useState } from 'react';
import { Form, Input, Button, Card, Typography, message, Checkbox } from 'antd';
import { UserOutlined, LockOutlined } from '@ant-design/icons';
import { useNavigate } from 'react-router-dom';
import { useMutation } from 'react-query';
import { useAuthStore } from '@/store/authStore';
import { authService } from '@/services/authService';
import { LoginRequest } from '@/types';

const { Title, Text } = Typography;

const Login: React.FC = () => {
  const [form] = Form.useForm();
  const navigate = useNavigate();
  const { login } = useAuthStore();

  const loginMutation = useMutation(authService.login, {
    onSuccess: (data) => {
      login(data.user, data.token);
      message.success('Login berhasil!');
      navigate('/dashboard');
    },
    onError: (error: any) => {
      message.error(error.message || 'Login gagal. Silakan coba lagi.');
    },
  });

  const handleSubmit = (values: LoginRequest) => {
    loginMutation.mutate(values);
  };

  return (
    <div style={{
      minHeight: '100vh',
      display: 'flex',
      justifyContent: 'center',
      alignItems: 'center',
      background: 'linear-gradient(135deg, #667eea 0%, #764ba2 100%)',
      padding: 20
    }}>
      <Card 
        style={{ 
          width: '100%', 
          maxWidth: 400,
          boxShadow: '0 8px 32px rgba(0, 0, 0, 0.1)',
          borderRadius: 12
        }}
      >
        <div style={{ textAlign: 'center', marginBottom: 32 }}>
          <Title level={2} style={{ marginBottom: 8, color: '#1890ff' }}>
            SumberMas ERP
          </Title>
          <Text type="secondary">
            Silakan masuk ke akun Anda
          </Text>
        </div>

        <Form
          form={form}
          name="login"
          onFinish={handleSubmit}
          layout="vertical"
          size="large"
        >
          <Form.Item
            name="email"
            label="Email"
            rules={[
              { required: true, message: 'Email wajib diisi!' },
              { type: 'email', message: 'Format email tidak valid!' }
            ]}
          >
            <Input 
              prefix={<UserOutlined />} 
              placeholder="Masukkan email Anda"
            />
          </Form.Item>

          <Form.Item
            name="password"
            label="Password"
            rules={[
              { required: true, message: 'Password wajib diisi!' },
              { min: 6, message: 'Password minimal 6 karakter!' }
            ]}
          >
            <Input.Password 
              prefix={<LockOutlined />} 
              placeholder="Masukkan password Anda"
            />
          </Form.Item>

          <Form.Item name="rememberMe" valuePropName="checked">
            <Checkbox>Ingat saya</Checkbox>
          </Form.Item>

          <Form.Item style={{ marginBottom: 16 }}>
            <Button 
              type="primary" 
              htmlType="submit" 
              block
              loading={loginMutation.isLoading}
              style={{ height: 48 }}
            >
              {loginMutation.isLoading ? 'Memproses...' : 'Masuk'}
            </Button>
          </Form.Item>

          <div style={{ textAlign: 'center' }}>
            <Button type="link" size="small">
              Lupa password?
            </Button>
          </div>
        </Form>

        <div style={{ 
          marginTop: 24, 
          paddingTop: 24, 
          borderTop: '1px solid #f0f0f0',
          textAlign: 'center'
        }}>
          <Text type="secondary" style={{ fontSize: 12 }}>
            © 2024 SumberMas. All rights reserved.
          </Text>
        </div>
      </Card>
    </div>
  );
};

export default Login;
