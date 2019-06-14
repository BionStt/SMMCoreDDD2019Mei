using MediatR;
using MediatR.Pipeline;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SmmCoreDDD2019.Application.Infrastructure;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Common;
using SmmCoreDDD2019.Common.Identity;
using SmmCoreDDD2019.Common.Services;
using SmmCoreDDD2019.Infrastructure;
using SmmCoreDDD2019.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByDepth;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent2;
using SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaanLeasingCetak;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByParent;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Query.GetStructureByStructureCode;
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
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDB.Command.CreateDataPerusahaanStrukturJabatan;
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



namespace SmmCoreDDD2019.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.Add(new ServiceDescriptor(typeof(ILog), new MyConsoleLogger()));    // singleton
            // services.Add(new ServiceDescriptor(typeof(ILog), typeof(MyConsoleLogger), ServiceLifetime.Transient)); // Transient
            //services.Add(new ServiceDescriptor(typeof(ILog), typeof(MyConsoleLogger), ServiceLifetime.Scoped));    // Scoped
            //https://www.tutorialsteacher.com/core/dependency-injection-in-aspnet-core
            //https://www.tutorialsteacher.com/core/internals-of-builtin-ioc-container-in-aspnet-core
            //BUAT BELAJAR

            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

           // services.AddTransient<INumberSequence, SmmCoreDDD2019.Common.Services.NumberSequence>();
            services.AddTransient<IRoles, Roles>();
            services.AddTransient<IFunctional, Functional>();

            // Add framework services.
            services.AddTransient<INotificationService, NotificationService>();
            services.AddTransient<IDateTime, MachineDateTime>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<ApplicationSignInManager>();
            services.AddTransient<ISmsSender, SmsSender>();

            // Add MediatR
            // services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));//gak perlu lagi krn udah otomatis register
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            // Domain Bus (Mediator)
            //services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
            //services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            //services.AddScoped<ICustomerAppService, CustomerAppService>();

            // Domain - Commands
            //services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Identity Services
            //services.AddTransient<IEmailSender, AuthEmailMessageSender>();
            //services.AddTransient<ISmsSender, AuthSMSMessageSender>();

            // Infra - Identity
            //services.AddScoped<IUser, AspNetUser>();

            //domain - command
            //services.AddMediatR(typeof(GetStructureByDepthQueryHandler).GetTypeInfo().Assembly);
            //services.AddMediatR(typeof(GetStructureByParentQueryHandler).GetTypeInfo().Assembly);
            //services.AddMediatR(typeof(GetStructureByParent2QueryHandler).GetTypeInfo().Assembly);
            //services.AddMediatR(typeof(GetStructureByStructureCodeQueryHandler).GetTypeInfo().Assembly);

            //services.AddMediatR(typeof(CreateAccountingDataAccountCommand).Assembly, typeof(CreateAccountingDataAccountCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingDataJournalCommand).Assembly, typeof(CreateAccountingDataJournalCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingDataJournalHeaderCommand).Assembly, typeof(CreateAccountingDataJournalHeaderCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingDataKursCommand).Assembly, typeof(CreateAccountingDataKursCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingDataMataUangCommand).Assembly, typeof(CreateAccountingDataMataUangCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingDataPeriodeCommand).Assembly, typeof(CreateAccountingDataPeriodeCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingDataSaldoAwalCommand).Assembly, typeof(CreateAccountingDataSaldoAwalCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateAccountingTipeJournalCommand).Assembly, typeof(CreateAccountingTipeJournalCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateBPKBDBCommand).Assembly, typeof(CreateBPKBDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateCustomerCommand).Assembly, typeof(CreateCustomerCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteCustomerCommand).Assembly, typeof(DeleteCustomerCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateCustomerCommand).Assembly, typeof(UpdateCustomerCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataKonsumenAvalistCommand).Assembly, typeof(CreateDataKonsumenAvalistCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataKonsumenAvalistCommand).Assembly, typeof(DeleteDataKonsumenAvalistCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataKonsumenAvalistCommand).Assembly, typeof(UpdateDataKonsumenAvalistCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataKontrakAngsuranCommand).Assembly, typeof(DeleteDataKontrakAngsuranCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataKontrakAngsuranCommand).Assembly, typeof(UpdateDataKontrakAngsuranCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataKontrakAsuransiCommand).Assembly, typeof(CreateDataKontrakAsuransiCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataKontrakAsuransiCommand).Assembly, typeof(DeleteDataKontrakAsuransiCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataKontrakAsuransiCommand).Assembly, typeof(UpdateDataKontrakAsuransiCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataKontrakKreditAngsuranDemoCommand).Assembly, typeof(CreateDataKontrakKreditAngsuranDemoCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataKontrakKreditAngsuranDemoCommand).Assembly, typeof(DeleteDataKontrakKreditAngsuranDemoCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataKontrakKreditCommand).Assembly, typeof(CreateDataKontrakKreditCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataKontrakKreditCommand).Assembly, typeof(DeleteDataKontrakKreditCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataKontrakKreditCommand).Assembly, typeof(UpdateDataKontrakKreditCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataKontrakSurveiCommand).Assembly, typeof(CreateDataKontrakSurveiCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataKontrakSurveiCommand).Assembly, typeof(DeleteDataKontrakSurveiCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataKontrakSurveiCommand).Assembly, typeof(UpdateDataKontrakSurveiCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataAwardCommand).Assembly, typeof(CreateDataPegawaiDataAwardCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataJabatanCommand).Assembly, typeof(CreateDataPegawaiDataJabatanCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataJabatanCommand).Assembly, typeof(DeleteDataPegawaiDataJabatanCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataJabatanCommand).Assembly, typeof(UpdateDataPegawaiDataJabatanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataKeluargaCommand).Assembly, typeof(CreateDataPegawaiDataKeluargaCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataKeluargaCommand).Assembly, typeof(DeleteDataPegawaiDataKeluargaCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataKeluargaCommand).Assembly, typeof(UpdateDataPegawaiDataKeluargaCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataOrmasCommand).Assembly, typeof(CreateDataPegawaiDataOrmasCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataOrmasCommand).Assembly, typeof(DeleteDataPegawaiDataOrmasCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataOrmasCommand).Assembly, typeof(UpdateDataPegawaiDataOrmasCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataPribadiInputCommand).Assembly, typeof(CreateDataPegawaiDataPribadiInputCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataPribadiCommand).Assembly, typeof(CreateDataPegawaiDataPribadiCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataPribadiCommand).Assembly, typeof(DeleteDataPegawaiDataPribadiCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataPribadiCommand).Assembly, typeof(UpdateDataPegawaiDataPribadiCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataRiwayatPekerjaanCommand).Assembly, typeof(CreateDataPegawaiDataRiwayatPekerjaanCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataRiwayatPekerjaanCommand).Assembly, typeof(DeleteDataPegawaiDataRiwayatPekerjaanCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataRiwayatPekerjaanCommand).Assembly, typeof(UpdateDataPegawaiDataRiwayatPekerjaanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataRiwayatPelatihanCommand).Assembly, typeof(CreateDataPegawaiDataRiwayatPelatihanCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataRiwayatPelatihanCommand).Assembly, typeof(DeleteDataPegawaiDataRiwayatPelatihanCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataRiwayatPelatihanCommand).Assembly, typeof(UpdateDataPegawaiDataRiwayatPelatihanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiDataRiwayatPendidikanCommand).Assembly, typeof(CreateDataPegawaiDataRiwayatPendidikanCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiDataRiwayatPendidikanCommand).Assembly, typeof(DeleteDataPegawaiDataRiwayatPendidikanCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiDataRiwayatPendidikanCommand).Assembly, typeof(UpdateDataPegawaiDataRiwayatPendidikanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiFotoCommand).Assembly, typeof(CreateDataPegawaiFotoCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiFotoCommand).Assembly, typeof(DeleteDataPegawaiFotoCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiFotoCommand).Assembly, typeof(UpdateDataPegawaiFotoCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPegawaiCommand).Assembly, typeof(CreateDataPegawaiCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPegawaiCommand).Assembly, typeof(DeleteDataPegawaiCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPegawaiCommand).Assembly, typeof(UpdateDataPegawaiCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPerusahaanCabangCommand).Assembly, typeof(CreateDataPerusahaanCabangCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPerusahaanCabangCommand).Assembly, typeof(DeleteDataPerusahaanCabangCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPerusahaanCabangCommand).Assembly, typeof(UpdateDataPerusahaanCabangCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPerusahaanCommand).Assembly, typeof(CreateDataPerusahaanCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataPerusahaanCommand).Assembly, typeof(DeleteDataPerusahaanCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataPerusahaanCommand).Assembly, typeof(UpdateDataPerusahaanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataPerusahaanStrukturJabatanCommand).Assembly, typeof(CreateDataPerusahaanStrukturJabatanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataSPKBaruDBCommand).Assembly, typeof(CreateDataSPKBaruDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataSPKBaruDBCommand).Assembly, typeof(DeleteDataSPKBaruDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataSPKBaruDBCommand).Assembly, typeof(UpdateDataSPKBaruDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataSPKKendaraanDBCommand).Assembly, typeof(CreateDataSPKKendaraanDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataSPKKendaraanDBCommand).Assembly, typeof(DeleteDataSPKKendaraanDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataSPKKendaraanDBCommand).Assembly, typeof(UpdateDataSPKKendaraanDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataSPKKreditDBCommand).Assembly, typeof(CreateDataSPKKreditDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataSPKKreditDBCommand).Assembly, typeof(DeleteDataSPKKreditDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataSPKKreditDBCommand).Assembly, typeof(UpdateDataSPKKreditDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataSPKLeasingDBCommand).Assembly, typeof(CreateDataSPKLeasingDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataSPKLeasingDBCommand).Assembly, typeof(DeleteDataSPKLeasingDBHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataSPKLeasingDBCommand).Assembly, typeof(UpdateDataSPKLeasingDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateDataSPKSurveiDBCommand).Assembly, typeof(CreateDataSPKSurveiDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteDataSPKSurveiDBCommand).Assembly, typeof(DeleteDataSPKSurveiDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDataSPKSurveiDBCommand).Assembly, typeof(UpdateDataSPKSurveiDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterAllowanceTypeDBCommand).Assembly, typeof(CreateMasterAllowanceTypeDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterBarangDBCommand).Assembly, typeof(CreateMasterBarangDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteMasterBarangDBCommand).Assembly, typeof(DeleteMasterBarangDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateMasterBarangDBCommand).Assembly, typeof(UpdateMasterBarangDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterJenisJabatanCommand).Assembly, typeof(CreateMasterJenisJabatanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterLeasingCabangDBCommand).Assembly, typeof(CreateMasterLeasingCabangDBHandler).Assembly);
            //services.AddMediatR(typeof(DeleteMasterLeasingCabangDBCommand).Assembly, typeof(DeleteMasterLeasingCabangDBHandler).Assembly);
            //services.AddMediatR(typeof(UpdateMasterLeasingCabangDBCommand).Assembly, typeof(UpdateMasterLeasingCabangDBHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterLeasingDbCommand).Assembly, typeof(CreateMasterLeasingDbHandler).Assembly);
            //services.AddMediatR(typeof(DeleteMasterLeasingDbCommand).Assembly, typeof(DeleteMasterLeasingDbHandler).Assembly);
            //services.AddMediatR(typeof(UpdateMasterLeasingDbCommand).Assembly, typeof(UpdateMasterLeasingDbHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterLeaveTypeHRDCommand).Assembly, typeof(CreateMasterLeaveTypeHRDCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterPerusahaanAsuransiCommand).Assembly, typeof(CreateMasterPerusahaanAsuransiCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteMasterPerusahaanAsuransiCommand).Assembly, typeof(DeleteMasterPerusahaanAsuransiCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateMasterPerusahaanAsuransiCommand).Assembly, typeof(UpdateMasterPerusahaanAsuransiCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateMasterSupplierDBCommand).Assembly, typeof(CreateMasterSupplierDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeleteMasterSupplierDBCommand).Assembly, typeof(DeleteMasterSupplierDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateMasterSupplierDBCommand).Assembly, typeof(UpdateMasterSupplierDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePembelianDetailCommand).Assembly, typeof(CreatePembelianDetailCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePembelianPODetailCommand).Assembly, typeof(CreatePembelianPODetailCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePembelianPOCommand).Assembly, typeof(CreatePembelianPOCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePembelianCommand).Assembly, typeof(CreatePembelianCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePejualanDetailCommand).Assembly, typeof(CreatePejualanDetailCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeletePenjualanDetailCommand).Assembly, typeof(DeletePenjualanDetailCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateCheckPenjualanDetailCommand).Assembly, typeof(UpdateCheckPenjualanDetailCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateDPPenjualanDetailCommand).Assembly, typeof(UpdateDPPenjualanDetailCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePenjualanPiutangCommand).Assembly, typeof(CreatePenjualanPiutangCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePenjualanCommand).Assembly, typeof(CreatePenjualanCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeletePenjualanCommand).Assembly, typeof(DeletePenjualanCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreatePermohonanFakturCommand).Assembly, typeof(CreatePermohonanFakturCommandHandler).Assembly);
            //services.AddMediatR(typeof(DeletePermohonanFakturCommand).Assembly, typeof(DeletePermohonanFakturCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateSTNKDBCommand).Assembly, typeof(CreateSTNKDBCommandHandler).Assembly);
            //services.AddMediatR(typeof(CreateStokUnitCommand).Assembly, typeof(CreateStokUnitCommandHandler).Assembly);
            //services.AddMediatR(typeof(UpdateStokUnitPembatalanPjCommand).Assembly, typeof(UpdateStokUnitPembatalanPjCommandHandler).Assembly);

            ////domain-query
            //services.AddMediatR(typeof(GetAllDataAccountOrderByKodeAccountQuery).Assembly, typeof(GetAllDataAccountOrderByKodeAccountQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataAccountByDepthQuery).Assembly, typeof(GetDataAccountByDepthQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataAccountByParentQuery).Assembly, typeof(GetDataAccountByParentQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataAccountByParent2Query).Assembly, typeof(GetDataAccountByParent2QueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataJournalAllQuery).Assembly, typeof(GetDataJournalAllQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataJournalByKodeAkunQuery).Assembly, typeof(GetDataJournalByKodeAkunQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataJournalByKodeHeaderQuery).Assembly, typeof(GetDataJournalByKodeHeaderQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLaporanLabaRugiQuery).Assembly, typeof(GetLaporanLabaRugiQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLaporanNeracaQuery).Assembly, typeof(GetLaporanNeracaQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataJournalHeaderQuery).Assembly, typeof(GetDataJournalHeaderQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetTipeJournalQuery).Assembly, typeof(GetTipeJournalQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetCustomerByIDQuery).Assembly, typeof(GetCustomerByIDQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetCustomerDataPenjualanQuery).Assembly, typeof(GetCustomerDataPenjualanQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetCustomerDetailQuery).Assembly, typeof(GetCustomerDetailQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetCustomersListQuery).Assembly, typeof(GetCustomersListQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataKonsumenAvalistQuery).Assembly, typeof(GetDataKonsumenAvalistQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataKontrakAngsuranByNoIDQuery).Assembly, typeof(GetDataKontrakAngsuranByNoIDQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetListDataKontrakKreditQuery).Assembly, typeof(GetListDataKontrakKreditQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetListDataKontrakKreditByNoIDQuery).Assembly, typeof(GetListDataKontrakKreditByNoIDQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataSurveiQuery).Assembly, typeof(GetDataSurveiQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaPegawaiQuery).Assembly, typeof(GetNamaPegawaiHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaSalesForceQuery).Assembly, typeof(GetNamaSalesForceQueryHandler).Assembly);
            //services.AddMediatR(typeof(DataPegawaiListQuery).Assembly, typeof(DataPegawaiListQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaPerusahaanQuery).Assembly, typeof(GetNamaPerusahaanHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaPerusahaanLeasingCetakQuery).Assembly, typeof(GetNamaPerusahaanLeasingCetakQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetStructureByDepthQuery).Assembly, typeof(GetStructureByDepthQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetStructureByParentQuery).Assembly, typeof(GetStructureByParentQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetStructureByParent2Query).Assembly, typeof(GetStructureByParent2QueryHandler).Assembly);
            //services.AddMediatR(typeof(GetStructureByStructureCodeQuery).Assembly, typeof(GetStructureByStructureCodeQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataKendaraanByNoSPKQuery).Assembly, typeof(GetDataKendaraanByNoSPKQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaSPKQuery).Assembly, typeof(GetNamaSPKHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaSPKPenjualanQuery).Assembly, typeof(GetNamaSPKPenjualanQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetMasterBarangByIDQuery).Assembly, typeof(GetMasterBarangByIDQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetMerekQuery).Assembly, typeof(GetMerekQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaBarangQrQuery).Assembly, typeof(GetNamaBarangQrHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaBarangQrByNoUrutQuery).Assembly, typeof(GetNamaBarangQrByNoUrutHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaBidangPekerjaanQuery).Assembly, typeof(GetNamaBidangPekerjaanQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaBidangUsahaQuery).Assembly, typeof(GetNamaBidangUsahaQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaJabatanQuery).Assembly, typeof(GetNamaJabatanQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaKategoryBayaranQuery).Assembly, typeof(GetNamaKategoryBayaranQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaCaraPembayaranQuery).Assembly, typeof(GetNamaCaraPembayaranQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaKategoryQuery).Assembly, typeof(GetNamaKategoryQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetCabangLeasingQuery).Assembly, typeof(GetCabangLeasingQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetAllLeasingQuery).Assembly, typeof(GetAllLeasingQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaSupplierQuery).Assembly, typeof(GetNamaSupplierHandler).Assembly);
            //services.AddMediatR(typeof(GetKodeBeliQuery).Assembly, typeof(GetKodeBeliQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetKodeBeliDetailQuery).Assembly, typeof(GetKodeBeliDetailQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLIstPembelianQuery).Assembly, typeof(GetLIstPembelianQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetListPembelianDetailQuery).Assembly, typeof(GetListPembelianDetailQueryHandle).Assembly);
            //services.AddMediatR(typeof(GetListStokUnitByNoKodeBeliQuery).Assembly, typeof(GetListStokUnitByNoKodeBeliQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPoPembelianQuery).Assembly, typeof(GetDataPoPembelianHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaPOQuery).Assembly, typeof(GetNamaPOHandler).Assembly);
            //services.AddMediatR(typeof(GetDataCekDPBulananQuery).Assembly, typeof(GetDataCekDPBulananQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataCekDPPenjualanQuery).Assembly, typeof(GetDataCekDPPenjualanQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataCekDPPenjualan2Query).Assembly, typeof(GetDataCekDPPenjualan2QueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataCheckPenjualanBulananQuery).Assembly, typeof(GetDataCheckPenjualanBulananQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataCheckPenjualanDetailBulananQuery).Assembly, typeof(GetDataCheckPenjualanDetailBulananQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataDetailLeasingCetakQuery).Assembly, typeof(GetDataDetailLeasingCetakQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPenjualanDetailByNoQuery).Assembly, typeof(GetDataPenjualanDetailByNoQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPenjualanDetailByNosinQuery).Assembly, typeof(GetDataPenjualanDetailByNosinQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPiutangLeasingQuery).Assembly, typeof(GetDataPiutangLeasingQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPiutangLeasingMerekQuery).Assembly, typeof(GetDataPiutangLeasingMerekQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLeasingCetakQuery).Assembly, typeof(GetLeasingCetakQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLeasingCetakBySearchQuery).Assembly, typeof(GetLeasingCetakBySearchQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPenjualanBulananBySalesQuery).Assembly, typeof(GetDataPenjualanBulananBySalesQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataPenjualanHarianQuery).Assembly, typeof(GetDataPenjualanHarianQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLaporanPenjualanPivotQuery).Assembly, typeof(GetLaporanPenjualanPivotQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLaporanPenjualanPivotCabangLeasingQuery).Assembly, typeof(GetLaporanPenjualanPivotCabangLeasingQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLaporanPenjualanPivotSalesQuery).Assembly, typeof(GetLaporanPenjualanPivotSalesQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaPenjualanFakturQuery).Assembly, typeof(GetNamaPenjualanFakturQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaFakturBPKBQuery).Assembly, typeof(GetNamaFakturBPKBQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetNamaFakturStnkQuery).Assembly, typeof(GetNamaFakturStnkQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataSOQuery).Assembly, typeof(GetDataSOQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetDataSOByIDQuery).Assembly, typeof(GetDataSOByIDQueryHandler).Assembly);
            //services.AddMediatR(typeof(GetLaporanSOQuery).Assembly, typeof(GetLaporanSOQueryHandler).Assembly);
            //services.AddMediatR(typeof(   ).Assembly, typeof(  ).Assembly);
            //services.AddMediatR(typeof(   ).Assembly, typeof(  ).Assembly);
            //services.AddMediatR(typeof(   ).Assembly, typeof(  ).Assembly);   
            //services.AddMediatR(typeof(   ).Assembly, typeof(  ).Assembly);
            //services.AddMediatR(typeof(   ).Assembly, typeof(  ).Assembly);
            //services.AddMediatR(typeof(   ).Assembly, typeof(  ).Assembly);


        }
    }
}
