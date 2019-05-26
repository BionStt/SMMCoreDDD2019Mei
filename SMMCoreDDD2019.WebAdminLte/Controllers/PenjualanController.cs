using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDataPenjualan;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPK;
using SmmCoreDDD2019.Application.DataSPKSurveiDBs.Queries.GetNamaSPKPenjualan;
using SmmCoreDDD2019.Application.MasterKategoriPenjualanDbs.Query.GetNamaKategory;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.CreatePejualanDetail;
using SmmCoreDDD2019.Application.Penjualans.Command.CreatePenjualan;
using SmmCoreDDD2019.Application.StokUnits.Query.GetDataSO;
using SmmCoreDDD2019.Application.StokUnits.Query.GetDataSOByID;

namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class PenjualanController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreatePenjualan()
        {
            var NamaKategoryPenjualan = await Mediator.Send(new GetNamaKategoryQuery());
            var NamaSalesForce1 = await Mediator.Send(new GetNamaSalesForceQuery());
            var LeasingCab = await Mediator.Send(new GetCabangLeasingQuery());
            var KodeCustomer = await Mediator.Send(new GetCustomerDataPenjualanQuery());
            var DataSPK = await Mediator.Send(new GetNamaSPKPenjualanQuery());

            ViewData["DataKonsumen"] = new SelectList(KodeCustomer.DataKonsumenDS, "NoCustomer", "NamaKonsumen");
            ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["NamaLeasingCabang"] = new SelectList(LeasingCab.MasterLeasingCabangDs.OrderBy(X => X.NamaCab), "NoUrutLeasingCabang", "NamaCab");
            ViewData["NamaKategoryPenjualan"] = new SelectList(NamaKategoryPenjualan.MasterKategoryPenjualanDs, "NoUrut", "NamaKategoryPenjualan");
            ViewData["DataSPK1"] = new SelectList(DataSPK.DataSPkPemesanDs, "NoUrutSPKBaru1", "NamaPemesan");


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePenjualan(CreatePenjualanCommand CreatePenjualanCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreatePenjualanCommand1);
                return RedirectToAction(nameof(PenjualanController.CreatePenjualanDetail), "Penjualan");

            }
            return View(CreatePenjualanCommand1);
        }

        [HttpGet]
        public async Task<IActionResult> CreatePenjualanDetail()
        {
            var KodeBarang = await Mediator.Send(new GetDataSOQuery());
            ViewData["NoSoBarang"] = new SelectList(KodeBarang.DataSODs, "NoUrutSO", "NamaBarang");

            var NamaPemesan = await Mediator.Send(new GetCustomerDataPenjualanQuery());
            ViewData["NamaPemesan1"] = new SelectList(NamaPemesan.DataKonsumenDS, "NoCustomer", "NamaKonsumen");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePenjualanDetail(CreatePejualanDetailCommand CreatePejualanDetailCommand1)
        {

            if (ModelState.IsValid)
            {
                await Mediator.Send(CreatePejualanDetailCommand1);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View(CreatePejualanDetailCommand1);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoUrutSO1)
        {

            var datakendaraan1 = await Mediator.Send(new GetDataSOByIDQuery { Id = NoUrutSO1 });

            var datakendaraan2 = datakendaraan1.DataKendaraanByNoUrutSODs.ToList();

            var zz = new
            {
                datakendaraan2[0].HargaOff,
                datakendaraan2[0].BBN,

            };

            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(zz));
        }



    }
}