using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.Inventory.InfrastructureData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterBarang",
                columns: table => new
                {
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NamaBarang = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorRangka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomorMesin = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Merek = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    KapasitasMesin = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    HargaOff = table.Column<decimal>(type: "money", nullable: true),
                    Bbn = table.Column<decimal>(type: "money", nullable: true),
                    TahunPerakitan = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TypeKendaraan = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MasterBarangStatus = table.Column<int>(type: "int", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterBarang", x => x.MasterBarangId);
                });

            migrationBuilder.CreateTable(
                name: "Pembelian",
                columns: table => new
                {
                    PembelianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalBeli = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JnsTransaksiPembelian = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tenor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNameInput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseOrderPembelianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Batal = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pembelian", x => x.PembelianId);
                });

            migrationBuilder.CreateTable(
                name: "PembelianDetail",
                columns: table => new
                {
                    PembelianDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PembelianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterBarangDBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HargaOffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    BBN = table.Column<decimal>(type: "money", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    SellIn = table.Column<decimal>(type: "money", nullable: true),
                    Harga1 = table.Column<decimal>(type: "money", nullable: true),
                    Diskon2 = table.Column<decimal>(type: "money", nullable: true),
                    SellIn2 = table.Column<decimal>(type: "money", nullable: true),
                    HargaPPN = table.Column<decimal>(type: "money", nullable: true),
                    DiskonPPN = table.Column<decimal>(type: "money", nullable: true),
                    SellInPPN = table.Column<decimal>(type: "money", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PembelianDetail", x => x.PembelianDetailId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderPembelian",
                columns: table => new
                {
                    PurchaseOrderPembelianId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalPurchaseOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MasterSupplierDBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiPoPMB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Terinput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserInput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoAstra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderPembelian", x => x.PurchaseOrderPembelianId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderPembelianDetail",
                columns: table => new
                {
                    PurchaseOrderPembelianDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterBarangDBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OffTheRoad = table.Column<decimal>(type: "money", nullable: true),
                    Bbn = table.Column<decimal>(type: "money", nullable: true),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    Warna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: true),
                    Keterangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderPembelianDetail", x => x.PurchaseOrderPembelianDetailId);
                });

            migrationBuilder.CreateTable(
                name: "StokUnit",
                columns: table => new
                {
                    StokUnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PembelianDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterBarangId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomorRangka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomorMesin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warna = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Jual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kembali = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faktur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Harga = table.Column<decimal>(type: "money", nullable: true),
                    Diskon = table.Column<decimal>(type: "money", nullable: true),
                    SellIn = table.Column<decimal>(type: "money", nullable: true),
                    Harga1 = table.Column<decimal>(type: "money", nullable: true),
                    Diskon2 = table.Column<decimal>(type: "money", nullable: true),
                    SellIn2 = table.Column<decimal>(type: "money", nullable: true),
                    HargaPPN = table.Column<decimal>(type: "money", nullable: true),
                    DiskonPPN = table.Column<decimal>(type: "money", nullable: true),
                    SellInPPN = table.Column<decimal>(type: "money", nullable: true),
                    TanggalInput = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StokUnit", x => x.StokUnitId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlamatSupplier_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatSupplier_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatSupplier_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatSupplier_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatSupplier_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatSupplier_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatSupplier_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatSupplier_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatSupplier_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NamaSupplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterBarang");

            migrationBuilder.DropTable(
                name: "Pembelian");

            migrationBuilder.DropTable(
                name: "PembelianDetail");

            migrationBuilder.DropTable(
                name: "PurchaseOrderPembelian");

            migrationBuilder.DropTable(
                name: "PurchaseOrderPembelianDetail");

            migrationBuilder.DropTable(
                name: "StokUnit");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
