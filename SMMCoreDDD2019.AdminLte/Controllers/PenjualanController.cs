using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.Inventory.ServiceApplication.StokUnit.Queries.GetDataSO;
using SumberMas2015.Inventory.ServiceApplication.StokUnit.Queries.GetDataSOByID;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.DtoMapping;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerDataPenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.GetNamaSPKPenjualan;
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
           // var NamaSalesForce1 = await _mediator.Send(new GetNamaSalesForceQuery());
            var LeasingCab = await _mediator.Send(new ListCabangLeasingQuery());
            var KodeCustomer = await _mediator.Send(new GetCustomerDataPenjualanQuery());
            var DataSPK = await _mediator.Send(new GetNamaSPKPenjualanQuery());

            ViewData["DataKonsumen"] = new SelectList(KodeCustomer, "NoCustomer", "NamaKonsumen");
           // ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["NamaLeasingCabang"] = new SelectList(LeasingCab, "NoUrutLeasingCabang", "NamaCab");
            ViewData["NamaKategoryPenjualan"] = new SelectList(NamaKategoryPenjualan, "NoUrutId", "KategoriPenjualan");
            ViewData["DataSPK1"] = new SelectList(DataSPK, "NoUrutSPKBaru1", "NamaPemesan");


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
            ViewData["NoSoBarang"] = new SelectList(KodeBarang, "NoUrutSO", "NamaBarang");

            var NamaPemesan = await _mediator.Send(new GetCustomerDataPenjualanQuery());
            ViewData["NamaPemesan1"] = new SelectList(NamaPemesan, "NoCustomer", "NamaKonsumen");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePenjualanDetail(CreateDataPenjualanDetailRequest CreatePejualanDetailCommand1)
        {

            if (ModelState.IsValid)
            {
                var xx = CreatePejualanDetailCommand1.ToCommand();

                await _mediator.Send(xx);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }

            return View(CreatePejualanDetailCommand1);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoUrutSO1)
        {

            var datakendaraan1 = await _mediator.Send(new GetDataSOByIDQuery { Id = NoUrutSO1 });

            var datakendaraan2 = datakendaraan1;

            var zz = new
            {
                datakendaraan2.HargaOff,
                datakendaraan2.BBN,

            };

            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(zz));
        }

    }
}
