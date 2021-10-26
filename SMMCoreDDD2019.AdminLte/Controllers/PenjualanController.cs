using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.DtoMapping;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.Queries.ListKategoriPenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListCabangLeasing;
using System;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class PenjualanController : Controller
    {
        private IMediator _mediator;

        public PenjualanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CreatePenjualan()
        {
            var NamaKategoryPenjualan = await _mediator.Send(new ListKategoriPenjualanQuery());
            var NamaSalesForce1 = await _mediator.Send(new GetNamaSalesForceQuery());
            var LeasingCab = await _mediator.Send(new ListCabangLeasingQuery());
            var KodeCustomer = await _mediator.Send(new GetCustomerDataPenjualanQuery());
            var DataSPK = await _mediator.Send(new GetNamaSPKPenjualanQuery());

            ViewData["DataKonsumen"] = new SelectList(KodeCustomer.DataKonsumenDS, "NoCustomer", "NamaKonsumen");
            ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["NamaLeasingCabang"] = new SelectList(LeasingCab.MasterLeasingCabangDs.OrderBy(X => X.NamaCab), "NoUrutLeasingCabang", "NamaCab");
            ViewData["NamaKategoryPenjualan"] = new SelectList(NamaKategoryPenjualan.MasterKategoryPenjualanDs, "NoUrut", "NamaKategoryPenjualan");
            ViewData["DataSPK1"] = new SelectList(DataSPK.DataSPkPemesanDs, "NoUrutSPKBaru1", "NamaPemesan");


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePenjualan(CreatePenjualanRequest CreatePenjualanCommand1)
        {
            if (ModelState.IsValid)
            {
                var xx = CreatePenjualanCommand1.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(PenjualanController.CreatePenjualanDetail), "Penjualan");

            }
            return View(CreatePenjualanCommand1);
        }

        [HttpGet]
        public async Task<IActionResult> CreatePenjualanDetail()
        {
            var KodeBarang = await _mediator.Send(new GetDataSOQuery());
            ViewData["NoSoBarang"] = new SelectList(KodeBarang.DataSODs, "NoUrutSO", "NamaBarang");

            var NamaPemesan = await _mediator.Send(new GetCustomerDataPenjualanQuery());
            ViewData["NamaPemesan1"] = new SelectList(NamaPemesan.DataKonsumenDS, "NoCustomer", "NamaKonsumen");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePenjualanDetail(CreatePejualanDetailCommand CreatePejualanDetailCommand1)
        {

            if (ModelState.IsValid)
            {
                await _mediator.Send(CreatePejualanDetailCommand1);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View(CreatePejualanDetailCommand1);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoUrutSO1)
        {

            var datakendaraan1 = await _mediator.Send(new GetDataSOByIDQuery { Id = NoUrutSO1 });

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
