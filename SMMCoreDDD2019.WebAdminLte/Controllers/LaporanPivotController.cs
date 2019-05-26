using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaSalesForce;
using SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanBulananBySales;
using SmmCoreDDD2019.Application.Penjualans.Query.GetDataPenjualanHarian;
using SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivot;
using SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivotCabangLeasing;
using SmmCoreDDD2019.Application.Penjualans.Query.GetLaporanPenjualanPivotSales;

namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class LaporanPivotController : BaseController
    {

        [HttpGet]
        public IActionResult IsianTanggalLaporanHarian()
        {
            return View();
        }
        public async Task<IActionResult> LaporanSalesHarian(DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {
            var DataPenjualanHarian1 = await Mediator.Send(new GetDataPenjualanHarianQuery { PeriodeAwal = PeriodeAwal, PeriodeAkhir = PeriodeAkhir });
            var DataPenjualanHarian2 = DataPenjualanHarian1.DataPenjualanHarianDS.OrderBy(x => x.TanggalPenjualan).ToList();
            return View(DataPenjualanHarian2);

        }

        [HttpGet]
        public async Task<IActionResult> IsianTanggalLaporanSalesBulananBySalesForce()
        {
            var SalesForce = await Mediator.Send(new GetNamaSalesForceQuery());
            var SalesForce1 = SalesForce.DataPegawaiDtPribadiDs.OrderBy(x => x.NamaDepan).ToList();
            ViewData["NoUrutSales"] = new SelectList(SalesForce1, "IDPegawai", "NamaDepan");
            return View();
        }
        public async Task<IActionResult> LaporanSalesForceBulanan(DateTime PeriodeAwal, DateTime PeriodeAkhir, string NoUrutSales)
        {
            var LaporanBulananSales = await Mediator.Send(new GetDataPenjualanBulananBySalesQuery { NoUrutSales = NoUrutSales, PeriodeAwal = PeriodeAwal, PeriodeAkhir = PeriodeAkhir });
            var LaporanBulananSales1 = LaporanBulananSales.DataPenjualanBulananSalesDS.OrderBy(x => x.TanggalPenjualan).ToList();
            return View(LaporanBulananSales1);


        }

        [HttpGet]
        public IActionResult IsianTanggalLaporanPenjualanPivot()
        {
            return View();
        }
        public async Task<IActionResult> LaporanPenjualanPivot(DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {

            var LaporanPivot = await Mediator.Send(new GetLaporanPenjualanPivotQuery { PeriodeAkhir = PeriodeAkhir, PeriodeAwal = PeriodeAwal });
            var LaporanPivot1 = LaporanPivot.DataPenjualanPivotDS.ToList();
            return View(LaporanPivot1);
        }
        [HttpGet]
        public async Task<IActionResult> IsianTanggalLaporanPenjualanPivotSales()
        {
            var SalesForce = await Mediator.Send(new GetNamaSalesForceQuery());
            var SalesForce1 = SalesForce.DataPegawaiDtPribadiDs.OrderBy(x => x.NamaDepan).ToList();
            ViewData["NoUrutSales"] = new SelectList(SalesForce1, "IDPegawai", "NamaDepan");
            return View();
        }
        public async Task<IActionResult> LaporanPenjualanPivotSales(DateTime PeriodeAwal, DateTime PeriodeAkhir, String NoUrutSales)
        {

            var LaporanPivot = await Mediator.Send(new GetLaporanPenjualanPivotSalesQuery { PeriodeAkhir = PeriodeAkhir, PeriodeAwal = PeriodeAwal, NoUrutSales = NoUrutSales });
            var LaporanPivot1 = LaporanPivot.DataPenjualanPivotSalesDS.ToList();
            return View(LaporanPivot1);
        }
        [HttpGet]
        public IActionResult IsianTanggalLaporanPenjualanPivotCabangLeasing()
        {
            return View();
        }

        public async Task<IActionResult> LaporanPenjualanPivotCabangLeasing(DateTime PeriodeAwal, DateTime PeriodeAkhir)
        {

            var LaporanPivot = await Mediator.Send(new GetLaporanPenjualanPivotCabangLeasingQuery { PeriodeAkhir = PeriodeAkhir, PeriodeAwal = PeriodeAwal });
            var LaporanPivot1 = LaporanPivot.DataPenjualanPivotCabangLeasingDS.ToList();
            return View(LaporanPivot1);
        }
    }
}