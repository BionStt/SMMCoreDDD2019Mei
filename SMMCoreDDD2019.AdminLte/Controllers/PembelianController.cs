using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class PembelianController : Controller
    {
        private IMediator _mediator;

        public PembelianController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CreatePembelianPO()
        {
            var NamaSupplier = await _mediator.Send(new GetNamaSupplierQuery());
            ViewData["NamaSupplier"] = new SelectList(NamaSupplier.MasterSupplierDs, "NoUrutSupplier", "NamaSupplier");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelianPO(CreatePembelianPOCommand PembelianPOViewModel)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(PembelianPOViewModel);

                return RedirectToAction(nameof(PembelianController.CreatePembelianPODetail), "Pembelian");
            }
            return View(PembelianPOViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreatePembelianPODetail()
        {
            var NamaBarang = await _mediator.Send(new GetNamaBarangQrQuery());
            var NamaPO = await _mediator.Send(new GetDataPoPembelianQuery());
            ViewData["NamaBarang"] = new SelectList(NamaBarang.MasterBarangDs, "NoUrutKendaraan", "NamaBarang");
            ViewData["NamaPO"] = new SelectList(NamaPO.DataPembelianPODs.OrderByDescending(x => x.NoUrutPoPembelian), "NoUrutPoPembelian", "NamaPOPembelian");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelianPODetail(CreatePembelianPODetailCommand PembelianPODetailViewModel)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(PembelianPODetailViewModel);

                return RedirectToAction(nameof(PembelianController.CreatePembelianPODetail), "Pembelian");
            }
            return View(PembelianPODetailViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> GetListPembelianDetail1A()
        {
            var DataPembelian = await _mediator.Send(new GetLIstPembelianQuery());
            ViewData["DataPembelian1"] = new SelectList(DataPembelian.DataPembelianDs.OrderByDescending(x => x.NoUrutPembelian), "NoUrutPembelian", "NamaPembelian");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetListPembelianDetail1A(string DataPmb1)
        {
            //apakah 2 baris perintah dibawah ini harus di kasih comment .krn tdk perlu eksekusik
            var DataPembelian = await _mediator.Send(new GetListPembelianDetailQuery { Id = DataPmb1 });
            IEnumerable<GetListPembelianDetailLookUpModel> model2 = DataPembelian.DataPembelianDetailDs;

            return RedirectToAction(nameof(PembelianController.GetListPembelianDetail2), "Pembelian", new { DataPmb1 = DataPmb1 });

        }

        //public IActionResult GetListPembelianDetail(string DataPmb1)
        //{
        //   // var DataPembelian = await Mediator.Send(new GetLIstPembelianQuery());
        //  //  ViewData["DataPembelian1"] = new SelectList(DataPembelian.DataPembelianDs, "NoUrutPembelian", "NamaPembelian");
        //    return RedirectToAction(nameof(PembelianController.GetListPembelianDetail2), "Pembelian", new { id = DataPmb1 });
        //    // return View();
        //}

        public async Task<IActionResult> GetListPembelianDetail2(string DataPmb1)
        {

            var DataPembelian = await _mediator.Send(new GetListPembelianDetailQuery { Id = DataPmb1 });

            IEnumerable<GetListPembelianDetailLookUpModel> model2 = DataPembelian.DataPembelianDetailDs;
            return View("GetListPembelianDetail2", model2);

        }

        [HttpGet]
        public async Task<IActionResult> InputStokUnit(string KodeBeliDetail)
        {
            var StokUnitDetail = await _mediator.Send(new GetListStokUnitByNoKodeBeliQuery { Id = KodeBeliDetail });
            var abc2 = StokUnitDetail.DataStokUnitDs.ToList();
            ViewBag.StokUnitItems = abc2;

            var KodeBeliDetail1 = await _mediator.Send(new GetKodeBeliDetailQuery { Id = KodeBeliDetail });
            var abc = KodeBeliDetail1.DataPembelianDetailDS.ToList();
            var abc1 = abc[0];
            ViewData["KodeBeli1"] = abc1.NoKodeBeli1;
            ViewData["KodeBeliDetail1"] = abc1.NoKodeBeliDetail;
            ViewData["KodeBrg1"] = abc1.KodeBarang;
            ViewData["Harga1"] = (double)abc1.HargaOff;
            ViewData["Diskon1"] = (double)abc1.Diskon1;
            ViewData["SellIn1"] = (double)abc1.SellIn1;
            ViewData["NamaBrg1"] = abc1.NamaBarang1;
            return View("InputStokUnit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> InputStokUnit(CreateStokUnitCommand StokUnitViewModel, string KodeBeli1)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(StokUnitViewModel);
                //  return RedirectToAction(nameof(PembelianController.GetListPembelianDetail), "Pembelian");
                //return RedirectToAction(nameof(PembelianController.GetListPembelianDetail2), "Pembelian",new { DataPmb1 = KodeBeli1 } );
            }
            var StokUnitDetail = await _mediator.Send(new GetListStokUnitByNoKodeBeliQuery { Id = StokUnitViewModel.KodeBeliDetail.ToString() });
            var abc2 = StokUnitDetail.DataStokUnitDs.ToList();
            ViewBag.StokUnitItems = abc2;

            var KodeBeliDetail1 = await _mediator.Send(new GetKodeBeliDetailQuery { Id = StokUnitViewModel.KodeBeliDetail.ToString() });
            var abc = KodeBeliDetail1.DataPembelianDetailDS.ToList();
            var abc1 = abc[0];
            ViewData["KodeBeli1"] = abc1.NoKodeBeli1;
            ViewData["KodeBeliDetail1"] = abc1.NoKodeBeliDetail;
            ViewData["KodeBrg1"] = abc1.KodeBarang;
            ViewData["Harga1"] = (double)abc1.HargaOff;
            ViewData["Diskon1"] = (double)abc1.Diskon1;
            ViewData["SellIn1"] = (double)abc1.SellIn1;
            ViewData["NamaBrg1"] = abc1.NamaBarang1;



            return View(StokUnitViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> CreatePembelian()
        {
            var NamaSupplier = await _mediator.Send(new GetNamaSupplierQuery());
            ViewData["NamaSupplier"] = new SelectList(NamaSupplier.MasterSupplierDs, "NoUrutSupplier", "NamaSupplier");

            var NamaKategoryCaraPembayaran = await _mediator.Send(new GetNamaCaraPembayaranQuery());
            ViewData["NamaKategoryCaraPembayaran"] = new SelectList(NamaKategoryCaraPembayaran.MasterCaraPembayaranDs, "NoUrut", "NamaKategoryCaraBayaran");

            var NamaPO = await _mediator.Send(new GetNamaPOQuery());
            ViewData["NamaPO"] = new SelectList(NamaPO.DataPODS.OrderByDescending(x => x.NoUrutPoPembelian), "NoUrutPoPembelian", "NamaPOPembelian");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelian(CreatePembelianCommand PembelianViewModel)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(PembelianViewModel);

                return RedirectToAction(nameof(PembelianController.CreatePembelianDetail), "Pembelian");
            }
            return View(PembelianViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreatePembelianDetail()
        {
            var NamaBarang = await _mediator.Send(new GetNamaBarangQrQuery());
            ViewData["NamaBarang"] = new SelectList(NamaBarang.MasterBarangDs, "NoUrutKendaraan", "NamaBarang");

            var KodeBeli = await _mediator.Send(new GetKodeBeliQuery());
            ViewData["KodeBeli"] = new SelectList(KodeBeli.DataPembelianDS.OrderByDescending(x => x.NoUrutPembelian), "NoUrutPembelian", "NamaPembelian");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelianDetail(CreatePembelianDetailCommand PembelianDetailViewModel)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(PembelianDetailViewModel);

                return RedirectToAction(nameof(PembelianController.CreatePembelianDetail), "Pembelian");
            }
            return View(PembelianDetailViewModel);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoUrutTypeBrg)
        {

            var datakendaraan1 = await _mediator.Send(new GetNamaBarangQrByNoUrutQuery { Id = NoUrutTypeBrg });

            var datakendaraan2 = datakendaraan1.MasterBarangDs.ToList();

            var zz = new
            {
                datakendaraan2[0].HargaOff,
                datakendaraan2[0].BBN1,

            };

            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(zz));
        }


    }
}
