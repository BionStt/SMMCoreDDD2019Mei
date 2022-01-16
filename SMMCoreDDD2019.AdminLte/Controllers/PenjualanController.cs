using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.SalesMarketing.Dto.Penjualan;
using SumberMas2015.SalesMarketing.DtoMapping;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerDataPenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Queries.GetNamaSPKPenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterKategoriPenjualan.Queries.ListKategoriPenjualan;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterLeasing.Queries.ListCabangLeasing;
using SumberMas2015.SalesMarketing.ServiceApplication.SalesMarketing.Queries.GetNamaSalesForce;
using SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Queries.GetDataSO;
using SumberMas2015.SalesMarketing.ServiceApplication.StokUnit.Queries.GetDataSOByID;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class PenjualanController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;
        private readonly string _userName;
        public PenjualanController(IMediator mediator, IHttpContextAccessor httpContextAccessor = null)
        {
            _mediator = mediator;
            _httpContextAccessor=httpContextAccessor;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
          
              _userName = httpContextAccessor.HttpContext.User.Identity.Name;//username

        }

        [HttpGet]
        public async Task<IActionResult> CreatePenjualan()
        {
            var NamaKategoryPenjualan = await _mediator.Send(new ListKategoriPenjualanQuery());
            var NamaSalesForce1 = await _mediator.Send(new GetNamaSalesForceQuery());
            var LeasingCab = await _mediator.Send(new ListCabangLeasingQuery());
            var KodeCustomer = await _mediator.Send(new GetCustomerDataPenjualanQuery());
            var DataSPK = await _mediator.Send(new GetNamaSPKPenjualanQuery());

            ViewData["UserId"] = _userId;
            ViewData["DataKonsumen"] = new SelectList(KodeCustomer, "NoCustomer", "NamaKonsumen");
            ViewData["NamaSalesForce"] = new SelectList(NamaSalesForce1, "NoUrutId", "NamasalesForce");
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
            var xx1 = string.Empty;

            if (KodeBarang.Count==1)
            {
                foreach (var xx in KodeBarang)
                {
                    xx1 = xx.NoUrutSO.ToString();
                }

                var xx2 = await _mediator.Send(new GetDataSOByIDQuery { Id =xx1 });
                ViewBag.HargaOffTheRoad = string.Format("{0:0}", xx2.HargaOff);
                ViewBag.BBN = string.Format("{0:0}", xx2.BBN);
                ViewBag.OTRR =string.Format("{0:0}", xx2.HargaOff+xx2.BBN);
            }
            ViewData["NoSoBarang"] = new SelectList(KodeBarang, "NoUrutSO", "NamaBarang");

            ViewData["UserId"] = _userId;

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
                xx.UserName = _userName;
                xx.UserNameId =Guid.Parse(_userId);

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
