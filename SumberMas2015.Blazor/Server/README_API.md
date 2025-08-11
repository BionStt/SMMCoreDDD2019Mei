# Sumber Mas Enterprise API Documentation

## Overview

Sumber Mas Enterprise API adalah sistem manajemen bisnis yang dibangun dengan arsitektur Domain-Driven Design (DDD) dan mengikuti standar enterprise-grade API.

## API Versioning

API menggunakan versioning dengan format: `api/v{version}/[controller]`

- **Current Version**: v1.0
- **URL Format**: `https://your-domain.com/api/v1/[controller]`
- **Header Version**: `X-API-Version: 1.0`

## Authentication

API menggunakan JWT Bearer token authentication:

```
Authorization: Bearer {your-jwt-token}
```

## Response Format

Semua API responses mengikuti format standar:

```json
{
  "success": true,
  "message": "Success message",
  "data": { /* response data */ },
  "errors": [],
  "timestamp": "2024-01-01T00:00:00Z",
  "requestId": "unique-request-id"
}
```

### Error Response Format

```json
{
  "success": false,
  "message": "Error message",
  "data": null,
  "errors": ["Detailed error 1", "Detailed error 2"],
  "timestamp": "2024-01-01T00:00:00Z",
  "requestId": "unique-request-id"
}
```

## HTTP Status Codes

- **200 OK**: Request successful
- **201 Created**: Resource created successfully
- **400 Bad Request**: Invalid request data
- **401 Unauthorized**: Authentication required
- **403 Forbidden**: Insufficient permissions
- **404 Not Found**: Resource not found
- **429 Too Many Requests**: Rate limit exceeded
- **500 Internal Server Error**: Server error

## Rate Limiting

- **Global Limit**: 100 requests per minute
- **Authenticated Users**: 200 requests per minute
- **Headers**: `X-RateLimit-Limit`, `X-RateLimit-Remaining`, `X-RateLimit-Reset`

## API Endpoints

### Master Barang (Products)

#### Create Product
```
POST /api/v1/MasterBarang/CreateMasterBarang
Content-Type: application/json
Authorization: Bearer {token}

{
  "namaBarang": "Product Name",
  "kodeBarang": "PROD001",
  "harga": 100000,
  "kategori": "Electronics"
}
```

### Data Konsumen (Customers)

#### Get Job Fields
```
GET /api/v1/DataKonsumen/GetNamaBidangPekerjaanAsync
Authorization: Bearer {token}
```

#### Get Business Fields
```
GET /api/v1/DataKonsumen/GetNamaBidangUsahaAsync
Authorization: Bearer {token}
```

#### Get Gender Types
```
GET /api/v1/DataKonsumen/GetJenisKelaminAsync
Authorization: Bearer {token}
```

#### Get Religions
```
GET /api/v1/DataKonsumen/GetAgamaListAsync
Authorization: Bearer {token}
```

#### Create Customer
```
POST /api/v1/DataKonsumen/CreateDataKonsumenAsync
Content-Type: application/json
Authorization: Bearer {token}

{
  "nama": "Customer Name",
  "email": "customer@example.com",
  "telepon": "08123456789",
  "alamat": "Customer Address"
}
```

## Health Check

```
GET /health
```

Returns system health status including:
- Database connectivity
- External service status
- System resources

## Swagger Documentation

Interactive API documentation available at:
```
https://your-domain.com/api-docs
```

## Logging

API logs all requests and responses with:
- Request ID for tracing
- User context
- Performance metrics
- Error details

Log files are stored in `logs/sumbermas-api-{Date}.txt`

## CORS Policy

Allowed origins:
- `https://localhost:5001`
- `https://localhost:5002`

## Security Features

- **HTTPS Only**: All communications encrypted
- **JWT Authentication**: Secure token-based auth
- **Rate Limiting**: Protection against abuse
- **Input Validation**: Comprehensive request validation
- **Error Handling**: Secure error responses
- **Audit Logging**: Complete request/response logging

## Development

### Prerequisites
- .NET 6.0
- SQL Server
- Visual Studio 2022 or VS Code

### Running Locally
```bash
cd SumberMas2015.Blazor/Server
dotnet restore
dotnet run
```

### API Documentation
```bash
# Access Swagger UI
http://localhost:5000/api-docs

# Health Check
http://localhost:5000/health
```

## Support

For API support and questions:
- Email: sutanto.gasali@gmail.com
- Website: https://sutantogasali.com
