# SumberMas2015 React Frontend

React frontend application untuk sistem ERP SumberMas2015 yang dibangun dengan TypeScript, Ant Design, dan React Query.

## 🚀 Features

- **Modern UI/UX**: Menggunakan Ant Design untuk konsistensi design
- **TypeScript**: Type safety dan better developer experience
- **State Management**: Zustand untuk global state management
- **API Integration**: React Query untuk efficient data fetching
- **Responsive Design**: Mobile-friendly interface
- **Authentication**: JWT-based authentication system
- **Module-based Architecture**: Terorganisir berdasarkan bounded context

## 🛠️ Tech Stack

- **React 18** dengan hooks
- **TypeScript** untuk type safety
- **Ant Design 5** untuk UI components
- **React Router 6** untuk routing
- **React Query** untuk state management & caching
- **Zustand** untuk global state
- **Axios** untuk HTTP client
- **Date-fns** untuk date manipulation

## 📁 Project Structure

```
src/
├── components/          # Reusable components
│   └── Layout/         # Layout components
├── pages/              # Page components
│   ├── Auth/          # Authentication pages
│   ├── Dashboard/     # Dashboard
│   ├── Inventory/     # Inventory module
│   ├── SalesMarketing/ # Sales & Marketing module
│   ├── Organization/   # Organization module
│   └── HumanCapital/   # Human Capital module
├── services/           # API services
├── store/             # Global state stores
├── types/             # TypeScript type definitions
├── utils/             # Utility functions
└── hooks/             # Custom React hooks
```

## 🔧 Installation

1. **Install dependencies**
   ```bash
   npm install
   ```

2. **Setup environment variables**
   ```bash
   cp .env.example .env.local
   ```
   Edit `.env.local` dan sesuaikan dengan konfigurasi API backend.

3. **Start development server**
   ```bash
   npm start
   ```

4. **Build for production**
   ```bash
   npm run build
   ```

## 🌐 Environment Variables

| Variable | Description | Default |
|----------|-------------|---------|
| `REACT_APP_API_URL` | Backend API URL | `https://localhost:5001/api` |
| `REACT_APP_ENV` | Environment | `development` |
| `REACT_APP_NAME` | Application name | `SumberMas2015 ERP` |

## 📋 Available Scripts

- `npm start` - Start development server
- `npm run build` - Build for production
- `npm test` - Run tests
- `npm run lint` - Run ESLint
- `npm run lint:fix` - Fix ESLint errors

## 🔐 Authentication

Aplikasi menggunakan JWT-based authentication dengan:
- Login/logout functionality
- Token storage di localStorage
- Automatic token refresh
- Protected routes

## 🗂️ Modules

### 1. Inventory Module
- Master Barang
- Stok Unit
- Supplier
- Pembelian

### 2. Sales & Marketing Module
- Data Konsumen
- Data Penjualan
- Data SPK (Surat Pesanan Kendaraan)

### 3. Organization Module
- Data Perusahaan
- Data Cabang
- Struktur Organisasi

### 4. Human Capital Module
- Data Pegawai
- Data Absensi
- Hari Libur

## 🔄 API Integration

Aplikasi terintegrasi dengan backend API SumberMas2015:

### Authentication Endpoints
- `POST /api/auth/login` - User login
- `POST /api/auth/logout` - User logout
- `POST /api/auth/refresh` - Refresh token

### Inventory Endpoints
- `GET /api/inventory/master-barang` - Get master barang
- `POST /api/inventory/master-barang` - Create master barang
- `PUT /api/inventory/master-barang/:id` - Update master barang
- `DELETE /api/inventory/master-barang/:id` - Delete master barang

### Sales Marketing Endpoints
- `GET /api/sales-marketing/konsumen` - Get konsumen
- `POST /api/sales-marketing/konsumen` - Create konsumen
- `GET /api/sales-marketing/spk` - Get SPK
- `POST /api/sales-marketing/spk` - Create SPK

## 🎨 UI/UX Features

- **Responsive Design**: Optimal di desktop dan mobile
- **Dark/Light Theme**: Support untuk multiple themes
- **Internationalization**: Ready untuk multi-language
- **Loading States**: Proper loading indicators
- **Error Handling**: User-friendly error messages
- **Form Validation**: Client-side validation dengan feedback

## 🧪 Testing

```bash
# Run all tests
npm test

# Run tests in watch mode
npm test -- --watch

# Run tests with coverage
npm test -- --coverage
```

## 🚀 Deployment

### Development
```bash
npm start
```

### Production Build
```bash
npm run build
```

### Docker Deployment
```bash
# Build Docker image
docker build -t sumbermas-react .

# Run container
docker run -p 3000:3000 sumbermas-react
```

## 🤝 Contributing

1. Fork the repository
2. Create feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to branch (`git push origin feature/AmazingFeature`)
5. Open Pull Request

## 📝 License

This project is proprietary software belonging to SumberMas2015.

## 📞 Support

Untuk support dan pertanyaan, hubungi tim development SumberMas2015.
