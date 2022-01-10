using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Identity.Pages
{
    public static partial class Pages
    {
        public static class HomeIndex
        {
            public const string Controller = "Home";
            public const string Action = "Index";
            public const string Role = "Home";
            public const string Url = "/Home/Index";
            public const string Name = "Home";
        }

        public static class ApplicationUser
        {
            public const string Controller = "ApplicationUser";
            public const string Action = "Index";
            public const string Role = "ApplicationUser";
            public const string Url = "/ApplicationUser/Index";
            public const string Name = "User Role";
        }
        public static class Leasing
        {
            public const string Name = "Leasing";
            public const string Role = "Leasing";
            public const string Url = "/Leasing/Create";
            public const string Controller = "Leasing";
            public const string Action = "Create";
        }
        public static class DataPerusahaan
        {
            public const string Name = "DataPerusahaan";
            public const string Role = "DataPerusahaan";
            public const string Url = "/DataPerusahaan/Create";
            public const string Controller = "DataPerusahaan";
            public const string Action = "Create";
        }
        public static class BPKB
        {
            public const string Name = "BPKB";
            public const string Role = "BPKB";
            public const string Url = "/Faktur/CreateMohonBPKB";
            public const string Controller = "Faktur";
            public const string Action = "CreateMohonBPKB";
        }
        public static class STNK
        {
            public const string Name = "STNK";
            public const string Role = "STNK";
            public const string Url = "/Faktur/CreateMohonSTNK";
            public const string Controller = "Faktur";
            public const string Action = "CreateMohonSTNK";
        }
        public static class PermohonanFaktur
        {
            public const string Name = "PermohonanFaktur";
            public const string Role = "PermohonanFaktur";
            public const string Url = "/Faktur/CreateMohonFaktur";
            public const string Controller = "Faktur";
            public const string Action = "CreateMohonFaktur";
        }
        public static class Customers
        {
            public const string Name = "Customers";
            public const string Role = "Customers";
            public const string Url = "/Customers/Create";
            public const string Controller = "Customers";
            public const string Action = "Create";
        }
        public static class POPembelian
        {
            public const string Name = "Pembelian";
            public const string Role = "Pembelian";
            public const string Url = "/Pembelian/CreatePembelianPO";
            public const string Controller = "Pembelian";
            public const string Action = "CreatePembelianPO";
        }
        public static class Pembelian
        {
            public const string Name = "Pembelian";
            public const string Role = "Pembelian";
            public const string Url = "/Pembelian/CreatePembelian";
            public const string Controller = "Pembelian";
            public const string Action = "CreatePembelian";
        }
        public static class DataSPK
        {
            public const string Name = "DataSPK";
            public const string Role = "DataSPK";
            public const string Url = "/DataSPK/CreateDataSPK";
            public const string Controller = "DataSPK";
            public const string Action = "CreateDataSPK";
        }
        public static class Penjualan
        {
            public const string Name = "Penjualan";
            public const string Role = "Penjualan";
            public const string Url = "/Penjualan/CreatePenjualan";
            public const string Controller = "Penjualan";
            public const string Action = "CreatePenjualan";
        }
        public static class Supplier
        {
            public const string Name = "Supplier";
            public const string Role = "Supplier";
            public const string Url = "/Supplier/Create";
            public const string Controller = "Supplier";
            public const string Action = "Create";
        }
        public static class MasterBarang
        {
            public const string Name = "MasterBarang";
            public const string Role = "MasterBarang";
            public const string Url = "/MasterBarang/Create";
            public const string Controller = "MasterBarang";
            public const string Action = "Create";
        }
        public static class DataPegawai
        {
            public const string Name = "DataPegawai";
            public const string Role = "DataPegawai";
            public const string Url = "/DataPegawai/CreateDataPegawai";
            public const string Controller = "DataPegawai";
            public const string Action = "CreateDataPegawai";
        }

    }
}
