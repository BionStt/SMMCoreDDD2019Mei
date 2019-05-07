using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.CreateDataSPKSurveiDB;
using SmmCoreDDD2019.Application.DataSPKKendaraanDBs.Command.CreateDataSPKKendaraanDB;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPK;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQr;
using SmmCoreDDD2019.Application.MasterKategoriPenjualanDbs.Query.GetNamaKategory;
using SmmCoreDDD2019.Application.MasterKategoriBayaranDbs.Query.GetNamaKategoryBayaran;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing;
using SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.CreateDataSPKKreditDB;
using SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.CreateDataSPKLeasingDB;
using SmmCoreDDD2019.Application.DataSPKLeasingDBs.Queries.GetDataKendaraanByNoSPK;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class DataSPKController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateDataSPK()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPK(CreateDataSPKSurveiDBCommand DataSPKViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataSPKViewModel);

                return RedirectToAction(nameof(DataSPKController.CreateDataSPKLeasing), "DataSPK");
            }
            return View(DataSPKViewModel);
        }

        public async Task<IActionResult> CreateDataSPKUnit()
        {
            var NamaL = await Mediator.Send(new GetNamaSPKQuery());
            var NamaBarang = await Mediator.Send(new GetNamaBarangQrQuery());
            ViewData["NamaPekerja"] = new SelectList(NamaL.DataSPkPemesanDs, "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaBarang"] = new SelectList(NamaBarang.MasterBarangDs, "NoUrutKendaraan", "NamaBarang");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPKUnit(CreateDataSPKKendaraanDBCommand DataSPKUnitViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataSPKUnitViewModel);
                return RedirectToAction(nameof(DataSPKController.CreateDataSPKKredit), "DataSPK");
              
            }
            return View(DataSPKUnitViewModel);
        }
        public async Task<IActionResult> CreateDataSPKLeasing()
        {
            var NamaL = await Mediator.Send(new GetNamaSPKQuery());
            var NamaKategoryPenjualan = await Mediator.Send(new GetNamaKategoryQuery());
            var NamaKategoryBayaran = await Mediator.Send(new GetNamaKategoryBayaranQuery());
            var NamaSalesForce1 = await Mediator.Send(new GetNamaSalesForceQuery());
            var LeasingCab = await Mediator.Send(new GetCabangLeasingQuery());

            ViewData["NamaPemesan"] = new SelectList(NamaL.DataSPkPemesanDs.OrderByDescending(X=>X.NoUrutSPKBaru1), "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaKategoryPenjualan"] = new SelectList(NamaKategoryPenjualan.MasterKategoryPenjualanDs, "NoUrut", "NamaKategoryPenjualan");
            ViewData["NamaKategoryBayaran"] = new SelectList(NamaKategoryBayaran.MasterKategoryBayaranDs, "NoUrut", "NamaKategoryBayaran");
            ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["NamaLeasingCabang"] = new SelectList(LeasingCab.MasterLeasingCabangDs.OrderBy(X=>X.NamaCab), "NoUrutLeasingCabang", "NamaCab");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPKLeasing(CreateDataSPKLeasingDBCommand DataSPKLeasingViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataSPKLeasingViewModel);
                return RedirectToAction(nameof(DataSPKController.CreateDataSPKUnit), "DataSPK");
              
            }
            return View(DataSPKLeasingViewModel);
        }

        public async Task<IActionResult> CreateDataSPKKredit()
        {
            var NamaL = await Mediator.Send(new GetNamaSPKQuery());
            var NamaBarang = await Mediator.Send(new GetNamaBarangQrQuery());
            ViewData["NamaPemesan"] = new SelectList(NamaL.DataSPkPemesanDs, "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaBarang"] = new SelectList(NamaBarang.MasterBarangDs, "NoUrutKendaraan", "NamaBarang");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPKKredit(CreateDataSPKKreditDBCommand DataSPKKreditViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataSPKKreditViewModel);

              

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(DataSPKKreditViewModel);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoSPK)
        {
          
            var datakendaraan1 = await Mediator.Send(new GetDataKendaraanByNoSPKQuery { Id= NoSPK } );
          
            var datakendaraan2 = datakendaraan1.DataKendaraanByNoSPKDs.ToList();
          
            var zz = new
            {
                datakendaraan2[0].HargaOff,
                datakendaraan2[0].BBN,

            };

            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(zz));
        }


    }
}