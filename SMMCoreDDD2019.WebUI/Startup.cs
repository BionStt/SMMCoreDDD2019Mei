using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB;
using SmmCoreDDD2019.Application.Infrastructure;
using SmmCoreDDD2019.Application.Infrastructure.AutoMapper;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList;
using SmmCoreDDD2019.Common;
using SmmCoreDDD2019.Infrastructure;
using SmmCoreDDD2019.Persistence;
using SMMCoreDDD2019.WebUI.Models;
using NSwag.AspNetCore;
using System.Reflection;
using SmmCoreDDD2019.Common.Identity;
using Microsoft.AspNetCore.Identity;
using SmmCoreDDD2019.Infrastructure.Services;
using Newtonsoft.Json.Serialization;
using SmmCoreDDD2019.Common.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using SmmCoreDDD2019.CrossCutting.IoC;
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

namespace SMMCoreDDD2019.WebUI
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

                    // email confirmation require
                    options.SignIn.RequireConfirmedEmail = identityDefaultOptions.SignInRequireConfirmedEmail;
                }
                )
               .AddEntityFrameworkStores<AppIdentityDbContext>()
               .AddDefaultTokenProviders();

            services.AddEntityFrameworkSqlServer();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.LoginPath = "/Account/Login2";
                options.LogoutPath = "/Account/Signout";
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

            services.AddMvc();
            // Add AutoMapper
            services.AddAutoMapper(new Assembly[] { typeof(AutoMapperProfile).GetTypeInfo().Assembly });

            // .NET Native DI Abstraction
            RegisterServices(services);
                        
          

            // Add MediatR
            //services.AddMediatR(typeof(GetProductQueryHandler).GetTypeInfo().Assembly);
            services.AddMediatR(typeof(GetCustomersListQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetAllDataAccountOrderByKodeAccountQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataAccountByDepthQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataAccountByParentQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataAccountByParent2QueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataJournalAllQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataJournalByKodeAkunQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataJournalByKodeHeaderQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLaporanLabaRugiQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLaporanNeracaQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataJournalHeaderQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetTipeJournalQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetCustomerByIDQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetCustomerDataPenjualanQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetCustomerDetailQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataKonsumenAvalistQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataKontrakAngsuranByNoIDQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetListDataKontrakKreditQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetListDataKontrakKreditByNoIDQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataSurveiQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaSalesForceQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaPegawaiHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(DataPegawaiListQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaPerusahaanHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaPerusahaanLeasingCetakQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetStructureByDepthQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetStructureByParentQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetStructureByParent2QueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetStructureByStructureCodeQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataKendaraanByNoSPKQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaSPKHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaSPKPenjualanQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetMasterBarangByIDQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetMerekQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaBarangQrHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaBarangQrByNoUrutHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaBidangPekerjaanQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaBidangUsahaQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaJabatanQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaKategoryBayaranQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaCaraPembayaranQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaKategoryQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetCabangLeasingQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetAllLeasingQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaSupplierHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetKodeBeliQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetKodeBeliDetailQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLIstPembelianQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetListPembelianDetailQueryHandle).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetListStokUnitByNoKodeBeliQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPoPembelianHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaPOHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataCekDPBulananQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataCekDPPenjualanQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataCekDPPenjualan2QueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataCheckPenjualanBulananQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataCheckPenjualanDetailBulananQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataDetailLeasingCetakQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPenjualanDetailByNoQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPenjualanDetailByNosinQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPiutangLeasingQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPiutangLeasingMerekQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLeasingCetakQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLeasingCetakBySearchQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPenjualanBulananBySalesQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataPenjualanHarianQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLaporanPenjualanPivotQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLaporanPenjualanPivotCabangLeasingQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLaporanPenjualanPivotSalesQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaPenjualanFakturQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaFakturBPKBQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetNamaFakturStnkQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataSOQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetDataSOByIDQueryHandler).GetTypeInfo().Assembly); // nambah sendiri
            services.AddMediatR(typeof(GetLaporanSOQueryHandler).GetTypeInfo().Assembly); // nambah sendiri


            // Add DbContext using SQL Server Provider
            services.AddDbContext<SMMCoreDDD2019DbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019Connection")));

            services.AddDbContext<AppIdentityDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("SmmCoreDDD2019IdentityConnection")));

          
            services
              .AddMvc(options => options.Filters.Add(typeof(CustomExceptionFilterAttribute)))
              .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
              .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateCustomerCommandValidator>());

            services.AddMvc()
           .AddJsonOptions(options =>
           {
               options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                //pascal case json
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();

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


            //   services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
            //if (env.IsDevelopment() || env.IsStaging())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //}
            //code removed for clarity 
            //https://www.tutorialsteacher.com/core/aspnet-core-exception-handling

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

          
            app.UseHttpsRedirection();
           
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseStaticFiles(); // For the wwwroot folder

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

            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "default",
                //    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                  name: "default",
                  template: "{controller=UserRole}/{action=UserProfile}/{id?}");
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

    }
}
