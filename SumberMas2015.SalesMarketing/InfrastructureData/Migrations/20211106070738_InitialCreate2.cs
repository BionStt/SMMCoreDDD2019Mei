using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SumberMas2015.SalesMarketing.InfrastructureData.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKKendaraan_DataSPK_DataSPKId",
                table: "DataSPKKendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKKendaraan_MasterBarang_MasterBarangId",
                table: "DataSPKKendaraan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKKredit_DataSPK_DataSPKId",
                table: "DataSPKKredit");

            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKLeasing_DataSPK_DataSPKId",
                table: "DataSPKLeasing");

            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKSurvei_DataSPK_DataSPKId",
                table: "DataSPKSurvei");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLeasingCabang_MasterLeasing_MasterLeasingId",
                table: "MasterLeasingCabang");

            migrationBuilder.DropIndex(
                name: "IX_DataSPKKendaraan_DataSPKId",
                table: "DataSPKKendaraan");

            migrationBuilder.DropIndex(
                name: "IX_DataSPKKendaraan_MasterBarangId",
                table: "DataSPKKendaraan");

            migrationBuilder.DropColumn(
                name: "UserInputID",
                table: "Penjualan");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalPenjualan",
                table: "Penjualan",
                type: "datetime",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "SalesUserId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterLeasingCabangId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterKategoriPenjualanId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DataKonsumenId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterLeasingId",
                table: "MasterLeasingCabang",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKSurvei",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalSurvei",
                table: "DataSPKLeasing",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "GetUtcDate()");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKLeasing",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKKredit",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterBarangId",
                table: "DataSPKKendaraan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKKendaraan",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Terinput",
                table: "DataKonsumen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DataSalesMarketing",
                columns: table => new
                {
                    DataSalesMarketingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false),
                    NamaSales = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSalesMarketing", x => x.DataSalesMarketingId);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanBPKB",
                columns: table => new
                {
                    PermohonanBPKBId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoUrutId = table.Column<int>(type: "int", nullable: false),
                    PermohonanFakturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomorBpkb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalTerimaBPKB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanBPKB", x => x.PermohonanBPKBId);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanFaktur",
                columns: table => new
                {
                    PermohonanFakturId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoRegistrasiFaktur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalMohonFaktur = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PenjualanDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalLahir = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NomorKTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaFaktur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlamatFaktur_Jalan = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    AlamatFaktur_Kelurahan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_Kecamatan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_Kota = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_Propinsi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AlamatFaktur_KodePos = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    AlamatFaktur_NoTelepon = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatFaktur_NoFax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    AlamatFaktur_NoHandphone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NoUrutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanFaktur", x => x.PermohonanFakturId);
                });

            migrationBuilder.CreateTable(
                name: "PermohonanSTNK",
                columns: table => new
                {
                    PermohonanSTNKId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TanggalBayarSTNK = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PermohonanFakturDBId = table.Column<int>(type: "int", nullable: true),
                    NoStnk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PajakStnk = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Birojasa = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BiayaTambahan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FormA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NomorPlat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perwil = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PajakProgresif = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BbnPabrik = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProgresifKe = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermohonanSTNK", x => x.PermohonanSTNKId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKKredit_DataSPK_DataSPKId",
                table: "DataSPKKredit",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKLeasing_DataSPK_DataSPKId",
                table: "DataSPKLeasing",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKSurvei_DataSPK_DataSPKId",
                table: "DataSPKSurvei",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLeasingCabang_MasterLeasing_MasterLeasingId",
                table: "MasterLeasingCabang",
                column: "MasterLeasingId",
                principalTable: "MasterLeasing",
                principalColumn: "MasterLeasingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKKredit_DataSPK_DataSPKId",
                table: "DataSPKKredit");

            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKLeasing_DataSPK_DataSPKId",
                table: "DataSPKLeasing");

            migrationBuilder.DropForeignKey(
                name: "FK_DataSPKSurvei_DataSPK_DataSPKId",
                table: "DataSPKSurvei");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterLeasingCabang_MasterLeasing_MasterLeasingId",
                table: "MasterLeasingCabang");

            migrationBuilder.DropTable(
                name: "DataSalesMarketing");

            migrationBuilder.DropTable(
                name: "PermohonanBPKB");

            migrationBuilder.DropTable(
                name: "PermohonanFaktur");

            migrationBuilder.DropTable(
                name: "PermohonanSTNK");

            migrationBuilder.DropColumn(
                name: "Terinput",
                table: "DataKonsumen");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalPenjualan",
                table: "Penjualan",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<Guid>(
                name: "SalesUserId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterLeasingCabangId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterKategoriPenjualanId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataKonsumenId",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserInputID",
                table: "Penjualan",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterLeasingId",
                table: "MasterLeasingCabang",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKSurvei",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TanggalSurvei",
                table: "DataSPKLeasing",
                type: "datetime",
                nullable: true,
                defaultValueSql: "GetUtcDate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKLeasing",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKKredit",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "MasterBarangId",
                table: "DataSPKKendaraan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DataSPKId",
                table: "DataSPKKendaraan",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKendaraan_DataSPKId",
                table: "DataSPKKendaraan",
                column: "DataSPKId");

            migrationBuilder.CreateIndex(
                name: "IX_DataSPKKendaraan_MasterBarangId",
                table: "DataSPKKendaraan",
                column: "MasterBarangId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKKendaraan_DataSPK_DataSPKId",
                table: "DataSPKKendaraan",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKKendaraan_MasterBarang_MasterBarangId",
                table: "DataSPKKendaraan",
                column: "MasterBarangId",
                principalTable: "MasterBarang",
                principalColumn: "MasterBarangId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKKredit_DataSPK_DataSPKId",
                table: "DataSPKKredit",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKLeasing_DataSPK_DataSPKId",
                table: "DataSPKLeasing",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataSPKSurvei_DataSPK_DataSPKId",
                table: "DataSPKSurvei",
                column: "DataSPKId",
                principalTable: "DataSPK",
                principalColumn: "DataSPKId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterLeasingCabang_MasterLeasing_MasterLeasingId",
                table: "MasterLeasingCabang",
                column: "MasterLeasingId",
                principalTable: "MasterLeasing",
                principalColumn: "MasterLeasingId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
