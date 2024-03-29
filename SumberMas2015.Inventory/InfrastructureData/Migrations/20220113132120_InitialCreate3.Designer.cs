﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SumberMas2015.Inventory.InfrastructureData.Context;

#nullable disable

namespace SumberMas2015.Inventory.InfrastructureData.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20220113132120_InitialCreate3")]
    partial class InitialCreate3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, (int)1L, 1);

            modelBuilder.Entity("SumberMas2015.DDD.InternalCommand.Domain.InternalCommand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ExecutedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SavedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InternalCommands", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.DDD.OutBox.Domain.OutBoxMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ExecutedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SavedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OutBoxMessages", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.MasterBarang", b =>
                {
                    b.Property<Guid>("MasterBarangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Bbn")
                        .HasColumnType("money");

                    b.Property<decimal?>("HargaOff")
                        .HasColumnType("money");

                    b.Property<string>("KapasitasMesin")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<int>("MasterBarangStatus")
                        .HasColumnType("int");

                    b.Property<string>("Merek")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("NamaBarang")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<string>("NomorMesin")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NomorRangka")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TahunPerakitan")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)");

                    b.Property<string>("TypeKendaraan")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserNameId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MasterBarangId");

                    b.ToTable("MasterBarang", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.Pembelian", b =>
                {
                    b.Property<Guid>("PembelianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Batal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JnsTransaksiPembelian")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<Guid>("PurchaseOrderPembelianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TanggalBeli")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Tenor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserNameInput")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PembelianId");

                    b.ToTable("Pembelian", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.PembelianDetail", b =>
                {
                    b.Property<Guid>("PembelianDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("BBN")
                        .HasColumnType("money");

                    b.Property<decimal?>("Diskon")
                        .HasColumnType("money");

                    b.Property<decimal?>("Diskon2")
                        .HasColumnType("money");

                    b.Property<decimal?>("DiskonPPN")
                        .HasColumnType("money");

                    b.Property<decimal?>("Harga1")
                        .HasColumnType("money");

                    b.Property<decimal?>("HargaOffTheRoad")
                        .HasColumnType("money");

                    b.Property<decimal?>("HargaPPN")
                        .HasColumnType("money");

                    b.Property<Guid>("MasterBarangDBId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<Guid>("PembelianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<decimal?>("SellIn")
                        .HasColumnType("money");

                    b.Property<decimal?>("SellIn2")
                        .HasColumnType("money");

                    b.Property<decimal?>("SellInPPN")
                        .HasColumnType("money");

                    b.HasKey("PembelianDetailId");

                    b.ToTable("PembelianDetail", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.PurchaseOrderPembelian", b =>
                {
                    b.Property<Guid>("PurchaseOrderPembelianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MasterSupplierDBId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NoRegistrasiPoPMB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<string>("PoAstra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TanggalPurchaseOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Terinput")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserNameId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PurchaseOrderPembelianId");

                    b.ToTable("PurchaseOrderPembelian", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.PurchaseOrderPembelianDetail", b =>
                {
                    b.Property<Guid>("PurchaseOrderPembelianDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Bbn")
                        .HasColumnType("money");

                    b.Property<decimal?>("Diskon")
                        .HasColumnType("money");

                    b.Property<string>("Keterangan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MasterBarangDBId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<decimal?>("OffTheRoad")
                        .HasColumnType("money");

                    b.Property<Guid>("PurchaseOrderPembelianId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("Warna")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PurchaseOrderPembelianDetailId");

                    b.ToTable("PurchaseOrderPembelianDetail", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.StokUnit", b =>
                {
                    b.Property<Guid>("StokUnitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Diskon")
                        .HasColumnType("money");

                    b.Property<decimal?>("Diskon2")
                        .HasColumnType("money");

                    b.Property<decimal?>("DiskonPPN")
                        .HasColumnType("money");

                    b.Property<string>("Faktur")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Harga")
                        .HasColumnType("money");

                    b.Property<decimal?>("Harga1")
                        .HasColumnType("money");

                    b.Property<decimal?>("HargaPPN")
                        .HasColumnType("money");

                    b.Property<string>("Jual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kembali")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MasterBarangId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<string>("NomorMesin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomorRangka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PembelianDetailId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("SellIn")
                        .HasColumnType("money");

                    b.Property<decimal?>("SellIn2")
                        .HasColumnType("money");

                    b.Property<decimal?>("SellInPPN")
                        .HasColumnType("money");

                    b.Property<DateTime>("TanggalInput")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TanggalTerjual")
                        .HasColumnType("datetime2");

                    b.Property<string>("Warna")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StokUnitId");

                    b.ToTable("StokUnit", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.Supplier", b =>
                {
                    b.Property<Guid>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaSupplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoUrutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoUrutId"), (int)1L, 1);

                    b.Property<Guid>("UserNameId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("SumberMas2015.Inventory.Domain.Supplier", b =>
                {
                    b.OwnsOne("SumberMas2015.Inventory.Domain.ValueObjects.Alamat", "AlamatSupplier", b1 =>
                        {
                            b1.Property<Guid>("SupplierId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Jalan")
                                .HasMaxLength(200)
                                .IsUnicode(false)
                                .HasColumnType("varchar(200)");

                            b1.Property<string>("Kecamatan")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Kelurahan")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("KodePos")
                                .HasMaxLength(7)
                                .HasColumnType("nvarchar(7)");

                            b1.Property<string>("Kota")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("NoFax")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("NoHandphone")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("NoTelepon")
                                .HasMaxLength(20)
                                .HasColumnType("nvarchar(20)");

                            b1.Property<string>("Propinsi")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("SupplierId");

                            b1.ToTable("Supplier");

                            b1.WithOwner()
                                .HasForeignKey("SupplierId");
                        });

                    b.Navigation("AlamatSupplier")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
