using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using SumberMas2015.SalesMarketing.Dto.DataSPK;
using SumberMas2015.SalesMarketing.DtoMapping;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.GetDataKendaraanByNoSPK;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.GetNamaSPK;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBarang.Queries.GetNamaBarang;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriBayaran.Queries.ListKategoriBayaran;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.Queries.ListKategoriPenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListCabangLeasing;
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
        public async Task<IActionResult> CreateDataSPK(CreateDataSPKSurveiRequest DataSPKViewModel)
        {

            if (ModelState.IsValid)
            {
                var xx = DataSPKViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(DataSPKController.CreateDataSPKLeasing), "DataSPK");
            }
            return View(DataSPKViewModel);
        }

        public async Task<IActionResult> CreateDataSPKUnit()
        {
            var NamaL = await _mediator.Send(new GetNamaSPKQuery());
            var NamaBarang = await _mediator.Send(new GetNamaBarangQuery());

            //dicek lagi
            ViewData["DataSPK1"] = new SelectList(NamaL, "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaBarang"] = new SelectList(NamaBarang, "NoUrutKendaraan", "NamaBarang");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPKUnit(CreateDataSPKKendaraanRequest DataSPKUnitViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = DataSPKUnitViewModel.ToCommand();

                await _mediator.Send(xx);

                return RedirectToAction(nameof(DataSPKController.CreateDataSPKKredit), "DataSPK");

            }
            return View(DataSPKUnitViewModel);
        }
        public async Task<IActionResult> CreateDataSPKLeasing()
        {
            var NamaL = await _mediator.Send(new GetNamaSPKQuery());
            var NamaKategoryPenjualan = await _mediator.Send(new ListKategoriPenjualanQuery());
            var NamaKategoryBayaran = await _mediator.Send(new ListKategoriBayaranQuery());
            var NamaSalesForce1 = await _mediator.Send(new GetNamaSalesForceQuery());
            var LeasingCab = await _mediator.Send(new ListCabangLeasingQuery());

            ViewData["NamaPemesan"] = new SelectList(NamaL, "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaKategoryPenjualan"] = new SelectList(NamaKategoryPenjualan, "NoUrut", "NamaKategoryPenjualan");
            ViewData["NamaKategoryBayaran"] = new SelectList(NamaKategoryBayaran, "NoUrut", "NamaKategoryBayaran");
            ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1, "IDPegawai", "NamaDepan");
            ViewData["NamaLeasingCabang"] = new SelectList(LeasingCab, "NoUrutLeasingCabang", "NamaCab");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPKLeasing(CreateDataSPKLeasingRequest DataSPKLeasingViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = DataSPKLeasingViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(DataSPKController.CreateDataSPKUnit), "DataSPK");

            }
            return View(DataSPKLeasingViewModel);
        }

        public async Task<IActionResult> CreateDataSPKKredit()
        {
            var NamaL = await _mediator.Send(new GetNamaSPKQuery());
            var NamaBarang = await _mediator.Send(new GetNamaBarangQuery());
            ViewData["NamaPemesan"] = new SelectList(NamaL, "NoUrutSPKBaru1", "NamaPemesan");
            ViewData["NamaBarang"] = new SelectList(NamaBarang, "NoUrutKendaraan", "NamaBarang");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataSPKKredit(CreateDataSPKKreditRequest DataSPKKreditViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = DataSPKKreditViewModel.ToCommand();

                await _mediator.Send(xx);



                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(DataSPKKreditViewModel);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoSPK)
        {

            var datakendaraan1 = await _mediator.Send(new GetDataKendaraanByNoSPKQuery { Id = NoSPK });



            var zz = new
            {
                datakendaraan1.HargaOff,
                datakendaraan1.BBN,

            };

            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(zz));
        }







    }
}
