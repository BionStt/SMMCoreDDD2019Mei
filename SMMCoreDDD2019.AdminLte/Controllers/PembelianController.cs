using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.Inventory.Dto.Pembelian;
using SumberMas2015.Inventory.Dto.PembelianDetail;
using SumberMas2015.Inventory.Dto.PurchaseOrderPembelian;
using SumberMas2015.Inventory.Dto.PurchaseOrderPembelianDetail;
using SumberMas2015.Inventory.Dto.StokUnit;
using SumberMas2015.Inventory.DtoMapping;
using SumberMas2015.Inventory.ServiceApplication.MasterBarang.Queries.GetNamaBarang;
using SumberMas2015.Inventory.ServiceApplication.MasterBarang.Queries.GetNamaBarangQrByNoUrut;
using SumberMas2015.Inventory.ServiceApplication.Pembelian.Queries.GetListPembelian;
using SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetKodeBeli;
using SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetKodeBeliDetail;
using SumberMas2015.Inventory.ServiceApplication.PembelianDetail.Queries.GetListPembelianDetail;
using SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Queries.GetDataPOPembelian;
using SumberMas2015.Inventory.ServiceApplication.PurchaseOrderPembelian.Queries.GetNamaPO;
using SumberMas2015.Inventory.ServiceApplication.StokUnit.Queries.GetListStokUnitByNoKodeBeli;
using SumberMas2015.Inventory.ServiceApplication.Supplier.Queries.GetNamaSupplier;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriCaraPembayaran.Queries.ListKategoriCaraPembayaran;
using System;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class PembelianController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userName;
        private readonly string _userId;
        public PembelianController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
           
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
            _userName = httpContextAccessor.HttpContext.User.Identity.Name;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        }
        [HttpGet]
        public async Task<IActionResult> CreatePembelianPO()
        {
            var NamaSupplier = await _mediator.Send(new GetNamaSupplierQuery());
            ViewData["NamaSupplier"] = new SelectList(NamaSupplier, "NoUrutSupplier", "NamaSupplier");
            ViewData["UserName"] = _userName;
            ViewData["UserId"] = _userId;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelianPO(CreatePurchaseOrderPembelianRequest PembelianPOViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = PembelianPOViewModel.ToCommand();

                await _mediator.Send(xx);

                return RedirectToAction(nameof(PembelianController.CreatePembelianPODetail), "Pembelian");
            }
            return View(PembelianPOViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreatePembelianPODetail()
        {
            var NamaBarang = await _mediator.Send(new GetNamaBarangQuery());
            var NamaPO = await _mediator.Send(new GetDataPOPembelianQuery());
            ViewData["NamaBarang"] = new SelectList(NamaBarang, "NoUrutKendaraan", "NamaBarang");
            ViewData["NamaPO"] = new SelectList(NamaPO, "NoUrutPoPembelian", "NamaPOPembelian");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelianPODetail(CreatePurchaseOrderPembelianDetailRequest PembelianPODetailViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = PembelianPODetailViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(PembelianController.CreatePembelianPODetail), "Pembelian");
            }
            return View(PembelianPODetailViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> GetListPembelianDetail1A()
        {
            var DataPembelian = await _mediator.Send(new GetListPembelianQuery());
            ViewData["DataPembelian1"] = new SelectList(DataPembelian, "NoUrutPembelian", "NamaPembelian");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetListPembelianDetail1A(string DataPmb1)
        {
            //apakah 2 baris perintah dibawah ini harus di kasih comment .krn tdk perlu eksekusik
            var DataPembelian = await _mediator.Send(new GetListPembelianDetailQuery { Id = DataPmb1 });

           // IEnumerable<GetListPembelianDetailLookUpModel> model2 = DataPembelian.DataPembelianDetailDs;

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


            return View("GetListPembelianDetail2", DataPembelian);

        }

        [HttpGet]
        public async Task<IActionResult> InputStokUnit(string KodeBeliDetail)
        {
            var StokUnitDetail = await _mediator.Send(new GetListStokUnitByNoKodeBeliQuery { Id = KodeBeliDetail });
           // var abc2 = StokUnitDetail.DataStokUnitDs.ToList();
            ViewBag.StokUnitItems = StokUnitDetail;

            var KodeBeliDetail1 = await _mediator.Send(new GetKodeBeliDetailQuery { Id = KodeBeliDetail });
            //var abc = KodeBeliDetail1.DataPembelianDetailDS.ToList();
            var abc1 = KodeBeliDetail1;
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
        public async Task<IActionResult> InputStokUnit(CreateStokUnitRequest StokUnitViewModel, string KodeBeli1)
        {
            if (ModelState.IsValid)
            {
                var xx = StokUnitViewModel.ToCommand();

                await _mediator.Send(xx);
                //  return RedirectToAction(nameof(PembelianController.GetListPembelianDetail), "Pembelian");
                //return RedirectToAction(nameof(PembelianController.GetListPembelianDetail2), "Pembelian",new { DataPmb1 = KodeBeli1 } );
            }
            var StokUnitDetail = await _mediator.Send(new GetListStokUnitByNoKodeBeliQuery { Id = StokUnitViewModel.pembelianDetailId.ToString() });

            ViewBag.StokUnitItems = StokUnitDetail;

            var KodeBeliDetail1 = await _mediator.Send(new GetKodeBeliDetailQuery { Id = StokUnitViewModel.pembelianDetailId.ToString() });
            var abc1 = KodeBeliDetail1;
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
            ViewData["NamaSupplier"] = new SelectList(NamaSupplier, "NoUrutSupplier", "NamaSupplier");

            var NamaKategoryCaraPembayaran = await _mediator.Send(new ListKategoriCaraPembayaranQuery());
            ViewData["NamaKategoryCaraPembayaran"] = new SelectList(NamaKategoryCaraPembayaran, "NoUrutId", "KategoriCaraPembayaran");

            var NamaPO = await _mediator.Send(new GetNamaPOQuery());
            ViewData["NamaPO"] = new SelectList(NamaPO, "NoUrutPoPembelian", "NamaPOPembelian");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelian(CreatePembelianRequest PembelianViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = PembelianViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(PembelianController.CreatePembelianDetail), "Pembelian");
            }
            return View(PembelianViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreatePembelianDetail()
        {
            var NamaBarang = await _mediator.Send(new GetNamaBarangQuery());
            ViewData["NamaBarang"] = new SelectList(NamaBarang, "NoUrutKendaraan", "NamaBarang");

            var KodeBeli = await _mediator.Send(new GetKodeBeliQuery());
            ViewData["KodeBeli"] = new SelectList(KodeBeli, "NoUrutPembelian", "NamaPembelian");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePembelianDetail(CreatePembelianDetailRequest PembelianDetailViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = PembelianDetailViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(PembelianController.CreatePembelianDetail), "Pembelian");
            }
            return View(PembelianDetailViewModel);
        }

        public async Task<JsonResult> GetHargaKendaraan(String NoUrutTypeBrg)
        {

            var datakendaraan1 = await _mediator.Send(new GetNamaBarangQrByNoUrutQuery { Id = NoUrutTypeBrg });

            var datakendaraan2 = datakendaraan1;

            var zz = new
            {
                datakendaraan2.HargaOff,
                datakendaraan2.BBN1,

            };

            return Json(Newtonsoft.Json.JsonConvert.SerializeObject(zz));
        }


    }
}
