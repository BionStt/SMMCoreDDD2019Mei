using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class DataSPKController : Controller
    {
        private IMediator _mediator;

        public DataSPKController(IMediator mediator)
        {
            _mediator = mediator;
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

            ViewData["NamaPemesan"] = new SelectList(NamaL.DataSPkPemesanDs.OrderByDescending(X => X.NoUrutSPKBaru1), "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaKategoryPenjualan"] = new SelectList(NamaKategoryPenjualan.MasterKategoryPenjualanDs, "NoUrut", "NamaKategoryPenjualan");
            ViewData["NamaKategoryBayaran"] = new SelectList(NamaKategoryBayaran.MasterKategoryBayaranDs, "NoUrut", "NamaKategoryBayaran");
            ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["NamaLeasingCabang"] = new SelectList(LeasingCab.MasterLeasingCabangDs.OrderBy(X => X.NamaCab), "NoUrutLeasingCabang", "NamaCab");

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

            var datakendaraan1 = await Mediator.Send(new GetDataKendaraanByNoSPKQuery { Id = NoSPK });

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
