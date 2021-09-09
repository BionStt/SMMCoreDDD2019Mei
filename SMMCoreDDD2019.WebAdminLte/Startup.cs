using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMMCoreDDD2019.WebAdminLte.Services;
using SMMCoreDDD2019.WebAdminLte.Services.Mail;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.CookiePolicy;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Persistence;
using FluentValidation;
using AutoMapper;

using MediatR;
using MediatR.Pipeline;
using SmmCoreDDD2019.Application.Infrastructure;
using SmmCoreDDD2019.Application.Infrastructure.AutoMapper;
using SmmCoreDDD2019.Application.Interfaces;

using SmmCoreDDD2019.Common;
using SmmCoreDDD2019.Infrastructure;
using NSwag.AspNetCore;
using System.Reflection;
using SmmCoreDDD2019.Infrastructure.Services;
using Newtonsoft.Json.Serialization;
using SmmCoreDDD2019.Common.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using SmmCoreDDD2019.CrossCutting.IoC;
using SMMCoreDDD2019.WebAdminLte.Models;


using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetAllDataAccountOrderByKodeAccount;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByDepth;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent2;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalAll;
using SmmCoreDDD2019.Application.StokUnits.Query.GetLaporanSO;
using SmmCoreDDD2019.Application.StokUnits.Query.GetDataSOByID;
using SmmCoreDDD2019.Application.StokUnits.Query.GetDataSO;
using SmmCoreDDD2019.Application.STNKDBs.Query.GetNamaFakturStnk;
using SmmCoreDDD2019.Application.STNKDBs.Query.GetNamaFakturBPKB;
using SmmCoreDDD2019.Application.Penjualans.Query.GetNamaPenjualanFaktur;
using SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivotSales;
using SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivotCabangLeasing;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeAkun;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeHeader;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanLabaRugi;
using SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Query.GetDataJournalHeader;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanNeraca;
using SmmCoreDDD2019.Application.AccountingTipeJournalDB.Query.GetTipeJournal;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDataPenjualan;
using SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Query.GetDataSurvei;
using SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Query.GetDataKontrakAngsuranByNoID;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBDetail;
using SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Query.GetDataKonsumenAvalist;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKredit;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKreditByNoID;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce;
using SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaan;
using SmmCoreDDD2019.Application.DataPegawaiFotos.Queries.GetDataPegawaiList;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaPegawai;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepth;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParent2;
using SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaanLeasingCetak;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParentC;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepthByChart;
using SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Query.GetNamaJabatan;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPKPenjualan;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPK;
using SmmCoreDDD2019.Application.DataSPKLeasingDBs.Queries.GetDataKendaraanByNoSPK;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMasterBarangByID;
using SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha;
using SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQr;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMerek;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQrByNoUrut;
using SmmCoreDDD2019.Application.MasterKategoriBayaranDbs.Query.GetNamaKategoryBayaran;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan2;
using SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeliDetail;
using SmmCoreDDD2019.Application.MasterLeasingDbs.Queries.GetAllLeasing;
using SmmCoreDDD2019.Application.MasterKategoriPenjualanDbs.Query.GetNamaKategory;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Queries.GetNamaSupplier;
using SmmCoreDDD2019.Application.MasterKategoriCaraPembayaranDB.Query.GetNamaCaraPembayaran;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPBulanan;
using SmmCoreDDD2019.Application.PembelianPOs.Query.GetDataPoPembelian;
using SmmCoreDDD2019.Application.PembelianDetails.Query.GetListStokUnitByNoKodeBeli;
using SmmCoreDDD2019.Application.PembelianDetails.Query.GetListPembelianDetail;
using SmmCoreDDD2019.Application.PembelianDetails.Query.GetLIstPembelian;
using SmmCoreDDD2019.Application.PembelianDetails.Query.GetKodeBeli;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanBulanan;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasing;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPenjualanDetailByNo;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanDetailBulanan;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan;
using SmmCoreDDD2019.Application.Pembelians.Query.GetNamaPO;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataDetailLeasingCetak;
using SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanBulananBySales;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPenjualanDetailByNosin;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetLeasingCetakBySearch;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetLeasingCetak;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasingMerek;
using SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanHarian;
using SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivot;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Command.CreateAccountingDataAccount;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Command.CreateAccountingDataJournal;
using SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Command.CreateAccountingDataJournalHeader;
using SmmCoreDDD2019.Application.AccountingDataKursDB.Command.CreateAccountingDataKurs;
using SmmCoreDDD2019.Application.AccountingDataMataUangDB.Command.CreateAccountingDataMataUang;
using SmmCoreDDD2019.Application.AccountingDataPeriodeDB.Command.CreateAccountingDataPeriode;
using SmmCoreDDD2019.Application.AccountingDataSaldoAwalDB.Command.CreateAccountingDataSaldoAwal;
using SmmCoreDDD2019.Application.AccountingTipeJournalDB.Command.CreateAccountingTipeJournal;
using SmmCoreDDD2019.Application.BPKBDBs.Command.CreateBPKBDB;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.DeleteCustomerDB;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.UpdateCustomerDB;
using SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.CreateDataKonsumenAvalist;
using SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.DeleteDataKonsumenAvalist;
using SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.UpdateDataKonsumenAvalist;
using SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Command.DeleteDataKontrakAngsuran;
using SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Command.UpdateDataKontrakAngsuran;
using SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.CreateDataKontrakAsuransi;
using SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.DeleteDataKontrakAsuransi;
using SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.UpdateDataKontrakAsuransi;
using SmmCoreDDD2019.Application.DataKontrakKreditAngsuranDemoDBs.Command.CreateDataKontrakKreditAngsuranDemo;
using SmmCoreDDD2019.Application.DataKontrakKreditAngsuranDemoDBs.Command.DeleteDataKontrakKreditAngsuranDemo;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.CreateDataKontrakKredit;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.DeleteDataKontrakKredit;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.UpdateDataKontrakKredit;
using SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.CreateDataKontrakSurvei;
using SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.DeleteDataKontrakSurvei;
using SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.UpdateDataKontrakSurvei;
using SmmCoreDDD2019.Application.DataPegawaiDataAwardDBs.Command.CreateDataPegawaiDataAward;
using SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.CreateDataPegawaiDataJabatan;
using SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.DeleteDataPegawaiDataJabatan;
using SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.UpdateDataPegawaiDataJabatan;
using SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.CreateDataPegawaiDataKeluarga;
using SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.DeleteDataPegawaiDataKeluarga;
using SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.UpdateDataPegawaiDataKeluarga;
using SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.CreateDataPegawaiDataOrmas;
using SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.UpdateDataPegawaiDataOrmas;
using SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.DeleteDataPegawaiDataOrmas;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.CreateDataPegawaiDataRiwayatPekerjaan;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.DeleteDataPegawaiDataPribadi;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.CreateDataPegawaiDataPribadi;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Command.CreateDataPegawaiDataPribadiInput;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadis.Command.UpdateDataPegawaiDataPribadi;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.DeleteDataPegawaiDataRiwayatPelatihan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.UpdateDataPegawaiDataRiwayatPekerjaan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.DeleteDataPegawaiDataRiwayatPekerjaan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.UpdateDataPegawaiDataRiwayatPelatihan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.CreateDataPegawaiDataRiwayatPelatihan;
using SmmCoreDDD2019.Application.StokUnits.Command.UpdateStokUnitPembatalanPj;
using SmmCoreDDD2019.Application.StokUnits.Command.CreateStokUnit;
using SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.CreatePermohonanFaktur;
using SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.DeletePermohonanFaktur;
using SmmCoreDDD2019.Application.STNKDBs.Command.CreateSTNKDB;
using SmmCoreDDD2019.Application.Penjualans.Command.DeletePenjualan;
using SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.CreateMasterPerusahaanAsuransi;
using SmmCoreDDD2019.Application.PembelianDetails.Command.CreatePembelianDetail;
using SmmCoreDDD2019.Application.Penjualans.Command.CreatePenjualan;
using SmmCoreDDD2019.Application.Pembelians.Command.CreatePembelian;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.DeletePenjualanDetail;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.CreateDataPegawaiDataRiwayatPendidikan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.DeleteDataPegawaiDataRiwayatPendidikan;
using SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.UpdateDataSPKLeasingDB;
using SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.DeleteDataSPKLeasingDB;
using SmmCoreDDD2019.Application.MasterBarangDBs.Commands.DeleteMasterBarangDBs;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.UpdateDataSPKSurveiDB;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.UpdateDataPegawaiDataRiwayatPendidikan;
using SmmCoreDDD2019.Application.DataPegawaiFotos.Command.CreateDataPegawaiFoto;
using SmmCoreDDD2019.Application.DataPegawaiFotos.Command.DeleteDataPegawaiFoto;
using SmmCoreDDD2019.Application.DataPegawaiFotos.Command.UpdateDataPegawaiFoto;
using SmmCoreDDD2019.Application.DataPegawais.Command.CreateDataPegawai;
using SmmCoreDDD2019.Application.DataPegawais.Command.DeleteDataPegawai;
using SmmCoreDDD2019.Application.DataPegawais.Command.UpdateDataPegawai;
using SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.CreateDataPerusahaanCabang;
using SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.DeleteDataPerusahaanCabang;
using SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.UpdateDataPerusahaanCabang;
using SmmCoreDDD2019.Application.DataPerusahaans.Command.DeleteDataPerusahaan;
using SmmCoreDDD2019.Application.DataPerusahaans.Command.CreateDataPerusahaan;
using SmmCoreDDD2019.Application.DataPerusahaans.Command.UpdateDataPerusahaan;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Command.CreateDataPerusahaanOrgChartDB;
using SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.CreateDataSPKBaruDB;
using SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.DeleteDataSPKBaruDB;
using SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.UpdateDataSPKBaruDB;
using SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.CreateDataSPKKendaraanDB;
using SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.DeleteDataSPKKendaraanDB;
using SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.UpdateDataSPKKendaraanDB;
using SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.CreateDataSPKKreditDB;
using SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.DeleteDataSPKKreditDB;
using SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.UpdateDataSPKKreditDB;
using SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.CreateDataSPKLeasingDB;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.CreateDataSPKSurveiDB;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.DeleteDataSPKSurveiDB;
using SmmCoreDDD2019.Application.MasterAllowanceTypeDB.Command.CreateMasterAllowanceTypeDB;
using SmmCoreDDD2019.Application.MasterBarangDBs.Commands.CreateMasterBarangDB;
using SmmCoreDDD2019.Application.MasterBarangDBs.Commands.UpdateMasterBarangDBs;
using SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Command.CreateMasterJenisJabatanDB;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.CreateMasterLeasingCabangDB;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.DeleteMasterLeasingCabangDB;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Commands.UpdateMasterLeasingCabangDB;
using SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.CreateMasterLeasingDb;
using SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.DeleteMasterLeasingDb;
using SmmCoreDDD2019.Application.MasterLeasingDbs.Commands.UpdateMasterLeasingDb;
using SmmCoreDDD2019.Application.MasterLeaveTypeHRDDB.Command.CreateMasterLeaveTypeHRD;
using SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.DeleteMasterPerusahaanAsuransi;
using SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.UpdateMasterPerusahaanAsuransi;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.DeleteMasterSupplierDB;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.UpdateMasterSupplierDB;
using SmmCoreDDD2019.Application.PembelianPODetails.Command.CreatePembelianPODetail;
using SmmCoreDDD2019.Application.PembelianPOs.Command.CreatePembelianPO;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.CreatePejualanDetail;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateCheckPenjualanDetail;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateDPPenjualanDetail;
using SmmCoreDDD2019.Application.PenjualanPiutangDB.Command.CreatePenjualanPiutang;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using FluentValidation.AspNetCore;
//using Lamar;
using Autofac;
using Autofac.Core;
using Scrutor;
using System.Runtime.Loader;

namespace SMMCoreDDD2019.WebAdminLte
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Get Identity Default Options
            IConfigurationSection identityDefaultOptionsConfigurationSection = Configuration.GetSection("IdentityDefaultOptions");

            services.Configure<IdentityDefaultOptions>(identityDefaultOptionsConfigurationSection);
            //apakah ini tdk sama dengan dibawah ???
            var identityDefaultOptions = identityDefaultOptionsConfigurationSection.Get<IdentityDefaultOptions>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Add DbContext using SQL Server Provider
            services.AddDbContext<ISMMCoreDDD2019DbContext, SMMCoreDDD2019DbContext>(options =>
               // options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019Connection"))
               options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019Connection"), sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null);
                })
                );


            services.AddDbContext<AppIdentityDbContext>(options =>
            //  options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019IdentityConnection"))
                   options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019IdentityConnection"), sqlServerOptionsAction: sqlOptions =>
                   {
                       sqlOptions.EnableRetryOnFailure(
                           maxRetryCount: 5,
                           maxRetryDelay: TimeSpan.FromSeconds(30),
                           errorNumbersToAdd: null);
                   })
              );

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                // Password settings
                options.Password.RequireDigit = identityDefaultOptions.PasswordRequireDigit;
                options.Password.RequiredLength = identityDefaultOptions.PasswordRequiredLength;
                options.Password.RequireNonAlphanumeric = identityDefaultOptions.PasswordRequireNonAlphanumeric;
                options.Password.RequireUppercase = identityDefaultOptions.PasswordRequireUppercase;
                options.Password.RequireLowercase = identityDefaultOptions.PasswordRequireLowercase;
                options.Password.RequiredUniqueChars = identityDefaultOptions.PasswordRequiredUniqueChars;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(identityDefaultOptions.LockoutDefaultLockoutTimeSpanInMinutes);
                options.Lockout.MaxFailedAccessAttempts = identityDefaultOptions.LockoutMaxFailedAccessAttempts;
                options.Lockout.AllowedForNewUsers = identityDefaultOptions.LockoutAllowedForNewUsers;

                // User settings
                options.User.RequireUniqueEmail = identityDefaultOptions.UserRequireUniqueEmail;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+";

                // email confirmation require
                options.SignIn.RequireConfirmedEmail = identityDefaultOptions.SignInRequireConfirmedEmail;
                // options.User.RequireUniqueEmail = identityDefaultOptions.UserRequireUniqueEmail;
            })
             .AddEntityFrameworkStores<AppIdentityDbContext>()
             // .AddDefaultUI(UIFramework.Bootstrap4)
               .AddDefaultTokenProviders();


            services.AddEntityFrameworkSqlServer();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";

                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                //  options.LoginPath = "/Account/Login2";
                //  options.LogoutPath = "/Account/Signout";
                options.Cookie = new CookieBuilder
                {
                    IsEssential = true // required for auth to work without explicit user consent; adjust to suit your privacy policy
                };

                // Cookie settings
                //options.Cookie.HttpOnly = identityDefaultOptions.CookieHttpOnly;
                //options.Cookie.Expiration = TimeSpan.FromDays(identityDefaultOptions.CookieExpiration);
                //options.LoginPath = identityDefaultOptions.LoginPath; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                //options.LogoutPath = identityDefaultOptions.LogoutPath; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                //options.AccessDeniedPath = identityDefaultOptions.AccessDeniedPath; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                //options.SlidingExpiration = identityDefaultOptions.SlidingExpiration;

            });

            // services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);



            //if (Configuration["Authentication:Facebook:IsEnabled"] == "true")
            //{
            //    services
            //        .AddAuthentication()
            //        .AddFacebook(facebookOptions => {
            //            facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
            //            facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            //        });
            //}

            //if (Configuration["Authentication:Google:IsEnabled"] == "true")
            //{
            //    services
            //        .AddAuthentication()
            //        .AddGoogle(googleOptions => {
            //            googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
            //            googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
            //        });
            //}


            // Get SendGrid configuration options
            //  services.Configure<SendGridOptions>(Configuration.GetSection("SendGridOptions"));

            // Get SMTP configuration options
            services.Configure<SmtpOptions>(Configuration.GetSection("SmtpOptions"));

            // Get Super Admin Default options
            services.Configure<SuperAdminDefaultOptions>(Configuration.GetSection("SuperAdminDefaultOptions"));

            services.Configure<EmailSettings>(Configuration.GetSection("EmailSettings"));
            ////lokalisasi bahasa UI??
            //  services.AddLocalization(options => options.ResourcesPath = "Resources");

            /*
             Add supporting localization to Mvc and set Directory of Resources files
             For example all resourcess will be in ~/Resources/Controllers/AboutController.en-GB.resx
            */
            services.AddMvc()
                .AddViewLocalization(
                    LanguageViewLocationExpanderFormat.Suffix,
                    opts => { opts.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization();
            //services.AddMvc()
            //  .AddDataAnnotationsLocalization(options => {
            //            options.DataAnnotationLocalizerProvider = (type, factory) =>
            //                         factory.Create(typeof(SharedResource));
            //  });

            //setelan utk lokalisasi bahasa UI ??
            services.Configure<RequestLocalizationOptions>(
             opts => {
                 var supportedCultures = new List<CultureInfo>
                        {
                             new CultureInfo("en-US"),
                              new CultureInfo("id-ID")
                        };

                 opts.DefaultRequestCulture = new RequestCulture("en-US");
                 // Formatting numbers, dates, etc.
                 opts.SupportedCultures = supportedCultures;
                 // UI strings that we have localized.
                 opts.SupportedUICultures = supportedCultures;

                 /*
                   At example below your URL will be looks as this:
                   http://localhost:5000/?lang=es-MX&ui-lang=es-MX
                */
                 // opts.RequestCultureProviders.Add(new QueryStringRequestCultureProvider() { QueryStringKey = "lang", UIQueryStringKey = "ui-lang" });

                 //opts.RequestCultureProviders.Insert(0, new CustomRequestCultureProvider(context => {
                 //    var settingService = context.RequestServices.GetService<Core.Service.SettingService>();
                 //    // My custom request culture logic
                 //    return Task.Run(() => new ProviderCultureResult(settingService.Get().Language));
                 //}));

             });


            services.AddMvc()
                .AddRazorPagesOptions(options =>
                {
                  //  options.AllowAreas = true;
                    options.Conventions.AuthorizeAreaFolder("Identity", "/Account/Manage");
                    options.Conventions.AuthorizeAreaPage("Identity", "/Account/Logout");


                });

            //services.Configure<PasswordHasherOptions>(options =>
            //      options.CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV3);

            services.Configure<MailManagerOptions>(Configuration.GetSection("Email"));

            if (Configuration["Email:EmailProvider"] == "SendGrid")
            {
                services.Configure<SendGridAuthOptions>(Configuration.GetSection("Email:SendGrid"));
                services.AddSingleton<IMailManager, SendGridMailManager>();
            }
            else
            {
                services.AddSingleton<IMailManager, EmptyMailManager>();
            }

            services.AddScoped<Services.Profile.ProfileManager>();

            // Add AutoMapper
              services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });

            services.AddSingleton<IConfiguration>(Configuration);
            // .NET Native DI Abstraction
            RegisterServices(services);

                      //services.AddMvc().AddRazorPagesOptions(options => {
            //    options.Conventions.AddAreaPageRoute("Identity", "/Account/Login", "");
            //}).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);




            services.AddMvc()
           .AddJsonOptions(options =>
           {
              // options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
               //pascal case json
             //  options.SerializerSettings.ContractResolver = new DefaultContractResolver();

           });

            // Customise default API behavour
            //services.Configure<ApiBehaviorOptions>(options =>
            //{
            //    options.SuppressModelStateInvalidFilter = true;
            //});

            // In production, the Angular files will be served from this directory
            //services.AddSpaStaticFiles(configuration =>
            //{
            //    configuration.RootPath = "ClientApp/dist";
            //});

            // Adding MediatR for Domain Events and Notifications
            //  services.AddMediatR(typeof(Startup));

            // Add MediatR
           // var dataAssembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName("SmmCoreDDD2019.Application"));
            var Assembly1a = AppDomain.CurrentDomain.Load("SmmCoreDDD2019.Application");
            services.AddMediatR(Assembly1a);
            //  services.AddMediatR(typeof(Startup));
            // services.AddMediatR(Assembly.GetExecutingAssembly());
            // if you have handlers/events in other assemblies
            //  services.AddMediatR(typeof(CreateDataSPKLeasingDBCommandHandler).Assembly,typeof(GetOrgChartByParentCQueryHandler).Assembly);

            // var applicationAssembly = typeof(CreateDataSPKLeasingDBCommandHandler).GetTypeInfo().Assembly;
            //  var Assembly1a = AppDomain.CurrentDomain.Load("SmmCoreDDD2019.Application");
            //services.AddMediatR(Assembly1a);
            // services.AddAutoMapper(Assembly1a);

            //var builder = new ContainerBuilder();
            // builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
            //.AsImplementedInterfaces();

            // // Register all the Command classes (they implement IAsyncRequestHandler)
            // // in assembly holding the Commands
            // builder.RegisterAssemblyTypes(
            //                       typeof(CreateDataSPKLeasingDBCommand).GetTypeInfo().Assembly).
            //                            AsClosedTypesOf(typeof(IRequestHandler<,>));
            // builder.RegisterAssemblyTypes(
            //                    typeof(CreateDataSPKLeasingDBCommand).GetTypeInfo().Assembly).
            //                         AsClosedTypesOf(typeof(IRequestHandler<>));
            // Other types registration


            //builder
            //        .RegisterAssemblyTypes(typeof(IRequest<>).Assembly)
            //        .Where(t => t.IsClosedTypeOf(typeof(IRequest<>)))
            //        .AsImplementedInterfaces();

            //builder
            //    .RegisterAssemblyTypes(typeof(IRequestHandler<>).Assembly)
            //    .Where(t => t.IsClosedTypeOf(typeof(IRequestHandler<>)))
            //    .AsImplementedInterfaces();
            //services.Scan(scan =>
            //  scan.FromAssemblies(Assembly1a)
            //    .AddClasses(classes => classes.AssignableTo(typeof(IRequestHandler<,>)))
            //    .AsImplementedInterfaces()
            //    .WithTransientLifetime());

            //   var commandHandlers = typeof(CreateDataSPKLeasingDBCommandHandler).Assembly.GetTypes()
            //    .Where(t => t.GetInterfaces().Any(i  => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<>))
            //);

            //   foreach (var handler in commandHandlers)
            //   {
            //       services.AddScoped(handler.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<>)), handler);
            //   }

            //   var queryHandlers = typeof(GetOrgChartByParentCQueryHandler).Assembly.GetTypes()
            //    .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>))
            //);

            //   foreach (var handler in queryHandlers)
            //   {
            //       services.AddScoped(handler.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)), handler);
            //   }


            //var classTypes = Assembly1a.ExportedTypes.Select(t => t.GetTypeInfo()).Where(t => t.IsClass && !t.IsAbstract);

            //foreach (var type in classTypes)
            //{
            //    var interfaces = type.ImplementedInterfaces.Select(i => i.GetTypeInfo());

            //    foreach (var handlerType in interfaces.Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)))
            //    {
            //        services.AddTransient(handlerType.AsType(), type.AsType());
            //    }
            //    foreach (var handlerType in interfaces.Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<>)))
            //    {
            //        services.AddTransient(handlerType.AsType(), type.AsType());
            //    }

            //    foreach (var handlerType in interfaces.Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequest<>)))
            //    {
            //        services.AddTransient(handlerType.AsType(), type.AsType());
            //    }
            //}
            //services.Scan(scan => scan
            //         .FromCallingAssembly()
            //         .AddClasses(classes => classes.InNamespaces("SmmCoreDDD2019.Application"))
            //         .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            //         .AsImplementedInterfaces()
            //         .WithTransientLifetime());


            //services.Scan(scan => scan
            //                       // .FromCallingAssembly(GetOrgChartByParentCQueryHandler) // 1. Find the concrete classes
            //                       .FromAssembliesOf(typeof(GetOrgChartByParentCQueryHandler))
            //                        //.FromAssemblyOf(typeof(Startup))
            //                        //.AddClasses()        //    to register
            //                       // .AddClasses(t => t.AssignableTo(typeof(IRequestHandler<,>)))
            //                     //.UsingRegistrationStrategy(RegistrationStrategy.Skip) // 2. Define how to handle duplicates
            //                   //  .AsImplementedInterfaces()
            //                      // .AsSelf()    // 2. Specify which services they are registered as
            //                    //  .WithTransientLifetime()) // 3. Set the lifetime for the services

            // .AddClasses(t => t.AssignableTo(typeof(IRequestHandler<,>)))
            //.UsingRegistrationStrategy(RegistrationStrategy.Skip) // 2. Define how to handle duplicates
            //.AsImplementedInterfaces()
            // .AsSelf()    // 2. Specify which services they are registered as
            //.WithTransientLifetime()); // 3. Set the lifetime for the services


            //  // services.AddMediatR(typeof(SomeHandler).Assembly,  typeof(SomeOtherHandler).Assembly); 
            ////Scan for commandhandlers and eventhandlers
            //services.Scan(scan => scan
            //    .FromAssemblies(typeof(CreateCustomerCommandHandler).GetTypeInfo().Assembly)
            //        .AddClasses(classes => classes.Where(x => {
            //            var allInterfaces = x.GetInterfaces();
            //            return
            //                allInterfaces.Any(y => y.GetTypeInfo().IsGenericType && y.GetTypeInfo().GetGenericTypeDefinition() == typeof(IRequest<>)) ||
            //                //allInterfaces.Any(y => y.GetTypeInfo().IsGenericType && y.GetTypeInfo().GetGenericTypeDefinition() == typeof(ICancellableHandler<>)) ||
            //                //allInterfaces.Any(y => y.GetTypeInfo().IsGenericType && y.GetTypeInfo().GetGenericTypeDefinition() == typeof(IRequestHandler<,>)) ||
            //                allInterfaces.Any(y => y.GetTypeInfo().IsGenericType && y.GetTypeInfo().GetGenericTypeDefinition() == typeof(IRequestHandler<,>));
            //        }))
            //        .AsSelf()
            //        .WithTransientLifetime()
            //);

            //var builder = new ContainerBuilder();
            //builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly)
            //.AsImplementedInterfaces();

            //// Register all the Command classes (they implement IAsyncRequestHandler)
            //// in assembly holding the Commands
            //builder.RegisterAssemblyTypes(
            //                      typeof(CreateDataPerusahaanStrukturJabatanCommand).GetTypeInfo().Assembly).
            //                           AsClosedTypesOf(typeof(IRequestHandler<,>));
            // Other types registration

            // services.AddScoped(typeof(ISMMCoreDDD2019DbContext), typeof(SMMCoreDDD2019DbContext));
            // Add MediatR
            //services.AddMediatR(typeof(CreateDataPerusahaanStrukturJabatanCommand).GetTypeInfo().Assembly);
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            // services.AddMediatR(typeof(CreateDataPerusahaanStrukturJabatanCommand).GetTypeInfo().Assembly);
            // services.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);
            //var queryHandlers = Assembly1a.GetExportedTypes().Where(t => t.Name.EndsWith("Handler"));
            //foreach (var handler in queryHandlers)
            //{
            //    services.AddMediatR(handler.GetTypeInfo().Assembly);
            //}

            //var queryHandlers1 = typeof(Startup).Assembly.GetTypes()
            // .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequestHandler<,>)));

            //foreach (var handler in queryHandlers)
            //{
            //    services.AddScoped(handler.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>)), handler);
            //}

            services
         .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
         .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        // .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateCustomerCommandValidator>());
            //.AddMvcOptions(options => {//tambahan dari web
            //     options.ModelMetadataDetailsProviders.Clear();
            //     options.ModelValidatorProviders.Clear();
            // });



        }

       

        //buat belajar
        //https://www.tutorialsteacher.com/core/aspnet-core-logging
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        //{
        //    // other code remove for clarity
        //    loggerFactory.AddFile("Logs/mylog-{Date}.txt");
        //}


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //https://www.tutorialsteacher.com/core/aspnet-core-exception-handling

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
             //   app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();// For the wwwroot folder
                                 // app.UseCookiePolicy();

            app.UseAuthentication();

            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(
            //                        Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
            //    RequestPath = new PathString("/app-images")
            //});
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Content")),
            //    RequestPath = new PathString("/Admin")
            //});
            //https://www.tutorialsteacher.com/core/aspnet-core-static-file

            //app.UseSwaggerUi3(settings =>
            //{
            //    settings.Path = "/api";
            //    settings.DocumentPath = "/api/specification.json";
            //});
           // app.UseMvcJQueryDataTables();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=UserRole}/{action=UserProfile}/{id?}");

                //    routes.MapRoute(
                //    name: "Default",
                //    url: "{controller}/{action}/{id}",
                //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });

                //routes.MapAreaRoute(
                //    name: "MyAreaServices",
                //    areaName: "Services",
                //    template: "Services/{controller=Home}/{action=Index}/{id?}");

            });

            //app.UseSpa(spa =>
            //{
            //    // To learn more about options for serving an Angular SPA from ASP.NET Core,
            //    // see https://go.microsoft.com/fwlink/?linkid=864501

            //    spa.Options.SourcePath = "ClientApp";

            //    if (env.IsDevelopment())
            //    {
            //        spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
            //    }
            //});


        }

        private static void RegisterServices(IServiceCollection services)
        {
            // Adding dependencies from another layers (isolated from Presentation)
            NativeInjectorBootStrapper.RegisterServices(services);
        }


        //public void ConfigureContainer(ContainerBuilder builder)
        //{
        //    builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

        //    builder.Register<ServiceFactory>(ctx =>
        //    {
        //        var c = ctx.Resolve<IComponentContext>();
        //        return t => c.TryResolve(t, out var o) ? o : null;
        //    }).InstancePerLifetimeScope();

        //    var dataAssembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName("SmmCoreDDD2019.Application"));
        //    // var servicesAssembly = AssemblyLoadContext.Default.LoadFromAssemblyName(new AssemblyName("FreelancerBlog.Services"));
        //    //builder.RegisterAssemblyTypes(dataAssembly, servicesAssembly, Assembly.GetEntryAssembly()).AsImplementedInterfaces();
        //    builder.RegisterAssemblyTypes(dataAssembly,  Assembly.GetEntryAssembly()).AsImplementedInterfaces();

        //    //builder.RegisterModule<AuthMessageSenderModule>();
        //    //builder.RegisterModule<FreelancerBlogDbContextSeedDataModule>();
        //    //builder.RegisterModule<FileManagerModule>();
        //    //builder.RegisterModule<FileSystemWrapperModule>();

        //}




    }
}
