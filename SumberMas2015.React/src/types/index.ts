// Auth Types
export interface User {
  id: string;
  userName: string;
  email: string;
  name: string;
  isEnabled: boolean;
  profilePictureUrl: string;
  isSuperAdmin: boolean;
  roles: string[];
}

export interface LoginRequest {
  email: string;
  password: string;
  rememberMe?: boolean;
}

export interface LoginResponse {
  token: string;
  user: User;
  expiresIn: number;
}

// API Response Types
export interface ApiResponse<T> {
  success: boolean;
  data: T;
  message?: string;
  errors?: string[];
}

export interface PaginatedResponse<T> {
  data: T[];
  totalCount: number;
  pageSize: number;
  currentPage: number;
  totalPages: number;
}

// Inventory Types
export interface MasterBarang {
  masterBarangId: string;
  namaBarang: string;
  nomorRangka: string;
  nomorMesin: string;
  merek: string;
  kapasitasMesin: string;
  hargaOff?: number;
  bbn?: number;
  tahunPerakitan: string;
  typeKendaraan: string;
  masterBarangStatus: number;
  noUrutId: number;
  userName: string;
  userNameId: string;
}

export interface CreateMasterBarangRequest {
  namaBarang: string;
  nomorRangka: string;
  nomorMesin: string;
  merek: string;
  kapasitasMesin: string;
  hargaOff?: number;
  bbn?: number;
  tahunPerakitan: string;
  typeKendaraan: string;
}

// Sales Marketing Types
export interface DataKonsumen {
  id: string;
  namaKonsumen: string;
  alamat: string;
  telepon: string;
  email: string;
  jenisKelamin: number;
  agama: number;
  bidangPekerjaan: string;
  createdDate: string;
  updatedDate?: string;
}

export interface DataPenjualan {
  id: string;
  nomorPenjualan: string;
  tanggalPenjualan: string;
  konsumenId: string;
  namaKonsumen: string;
  totalHarga: number;
  status: number;
  createdDate: string;
}

export interface DataSPK {
  id: string;
  nomorSPK: string;
  tanggalSPK: string;
  konsumenId: string;
  namaKonsumen: string;
  masterBarangId: string;
  namaBarang: string;
  hargaJual: number;
  statusInputSPK: number;
  createdDate: string;
}

// Organization Types
export interface DataPerusahaan {
  dataPerusahaanId: string;
  namaPerusahaan: string;
  alamatPerusahaan: string;
  penanggungJawab: string;
  createdDate: string;
  updatedDate?: string;
}

// Human Capital Types
export interface DataPegawai {
  id: string;
  namaPegawai: string;
  nip: string;
  jabatan: string;
  departemen: string;
  tanggalMasuk: string;
  status: number;
  email: string;
  telepon: string;
}

// Form Types
export interface FormState {
  isLoading: boolean;
  errors: Record<string, string>;
}

// Table Types
export interface TableColumn {
  key: string;
  title: string;
  dataIndex: string;
  sorter?: boolean;
  filterable?: boolean;
  width?: number;
  render?: (value: any, record: any, index: number) => React.ReactNode;
}

// Enum Types
export enum JenisKelamin {
  Pria = 0,
  Wanita = 1
}

export enum Agama {
  Islam = 0,
  Kristen = 1,
  Katolik = 2,
  Hindu = 3,
  Buddha = 4,
  Konghucu = 5
}

export enum StatusInputSPK {
  Draft = 0,
  Submitted = 1,
  Approved = 2,
  Rejected = 3
}

export enum MasterBarangStatus {
  Aktif = 0,
  TidakAktif = 1
}
