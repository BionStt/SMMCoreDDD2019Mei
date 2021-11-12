using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetDataPenjualanBulananBySales;
using SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetDataPenjualanHarian;
using SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivot;
using SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivotCabangLeasing;
using SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetLaporanPenjualanPivotSales;
using SumberMas2015.SalesMarketing.ServiceApplication.SalesMarketing.Queries.GetNamaSalesForce;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class LaporanPivotController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;

        public LaporanPivotController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator=mediator;
            _httpContextAccessor=httpContextAccessor;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;//userID Guid



        }
        [HttpGet]
        public IActionResult LaporanSalesHarian()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LaporanSalesHarian(DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {
            var DataPenjualanHarian1 = await _mediator.Send(new GetDataPenjualanHarianQuery { PeriodeAwal = PeriodeAwal, PeriodeAkhir = PeriodeAkhir });
           // var DataPenjualanHarian2 = DataPenjualanHarian1;
            return View(DataPenjualanHarian1);

        }

    
        [HttpGet]
        public async Task<IActionResult> LaporanSalesForceBulanan()
        {

            var SalesForce = await _mediator.Send(new GetNamaSalesForceQuery());
            // var SalesForce1 = SalesForce.DataPegawaiDtPribadiDs.OrderBy(x => x.NamaDepan).ToList();
            ViewData["NoUrutSales"] = new SelectList(SalesForce, "NoUrutId", "NamasalesForce");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LaporanSalesForceBulanan(DateTime PeriodeAwal, DateTime PeriodeAkhir, string NoUrutSales)
        {
            var LaporanBulananSales = await _mediator.Send(new GetDataPenjualanBulananBySalesQuery { NoUrutSales = NoUrutSales, PeriodeAwal = PeriodeAwal, PeriodeAkhir = PeriodeAkhir });
            return View(LaporanBulananSales);


        }
        [HttpGet]
        public IActionResult LaporanPenjualanPivot()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> LaporanPenjualanPivot(DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {

            var LaporanPivot = await _mediator.Send(new GetLaporanPenjualanPivotQuery { PeriodeAkhir = PeriodeAkhir, PeriodeAwal = PeriodeAwal });
          
            return View(LaporanPivot);
        }
        [HttpGet]
        public IActionResult LaporanPenjualanPivotSales()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LaporanPenjualanPivotSales(DateTime PeriodeAwal, DateTime PeriodeAkhir, String NoUrutSales)
        {

            var LaporanPivot = await _mediator.Send(new GetLaporanPenjualanPivotSalesQuery { PeriodeAkhir = PeriodeAkhir, PeriodeAwal = PeriodeAwal, NoUrutSales = NoUrutSales });
           // var LaporanPivot1 = LaporanPivot.DataPenjualanPivotSalesDS.ToList();
            return View(LaporanPivot);
        }
        [HttpGet]
        public IActionResult LaporanPenjualanPivotCabangLeasing()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> LaporanPenjualanPivotCabangLeasing(DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {

            var LaporanPivot = await _mediator.Send(new GetLaporanPenjualanPivotCabangLeasingQuery { PeriodeAkhir = PeriodeAkhir, PeriodeAwal = PeriodeAwal });
            
            return View(LaporanPivot);
        }

    }
}
