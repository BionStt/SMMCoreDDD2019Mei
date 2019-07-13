using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using SmmCoreDDD2019.Application.DataPerusahaans.Command.CreateDataPerusahaan;
using SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.CreateDataPerusahaanCabang;
using SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaan;
using Microsoft.AspNetCore.Mvc.Rendering;

using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParentC;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByDepthByChart;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Query.GetOrgChartByParent2;
using SmmCoreDDD2019.Application.DataPerusahaanOrgChartDB.Command.CreateDataPerusahaanOrgChartDB;

namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class DataPerusahaanController : BaseController
    {

        [HttpGet]
        [Route("DataPerusahaan/DataCabangCreate")]
        public async Task<IActionResult> DataCabangCreate()
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanQuery());
            ViewData["NamaPerusahaan"] = new SelectList(DataPerusahaan.NamaPerusahaanBDs, "IDPerusahaan", "NamaPerusahaan");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DataPerusahaan/DataCabangCreate")]
        public async Task<IActionResult> DataCabangCreate(CreateDataPerusahaanCabangCommand DataPerusahaanCabangViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPerusahaanCabangViewModel);
                // return RedirectToAction(nameof(DataPerusahaanController.DataCabangCreate), "DataPerusahaan");
            }
            return View(DataPerusahaanCabangViewModel);
        }

        [HttpGet]
        public IActionResult CreateDataPerusahaan()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPerusahaan(CreateDataPerusahaanCommand DataPerusahaanViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPerusahaanViewModel);
                return RedirectToAction(nameof(DataPerusahaanController.DataCabangCreate), "DataPerusahaan");
            }
            return View(DataPerusahaanViewModel);
        }

        
        public async Task<IActionResult> CreateStructureOrganization()
        {
                var DataAccounting = await Mediator.Send(new GetOrgChartByParentCQuery());
                ViewData["DataAkun1"] = new SelectList(DataAccounting.DataOrgChartParentCDs.ToList(), "NoUrutStrukturID", "DataAkun1");
                return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStructureOrganization(string KodeAccount1, string Parent1a,string Parent1, string Account1a, CreateDataPerusahaanOrgChartDBCommand CreateDataPerusahaanStrukturJabatanCommand1)
        {
            string NilaiParent;
            if (Parent1 == "0")
            {
                NilaiParent = Parent1a;
            }
            else
            {
                NilaiParent = Parent1;

            };
            CreateDataPerusahaanStrukturJabatanCommand1.Parent = NilaiParent;
            CreateDataPerusahaanStrukturJabatanCommand1.KodeStrukturJabatan = KodeAccount1;
            CreateDataPerusahaanStrukturJabatanCommand1.NamaStrukturJabatan = Account1a;


            if (CreateDataPerusahaanStrukturJabatanCommand1 != null)
            {
                await Mediator.Send(CreateDataPerusahaanStrukturJabatanCommand1);
                return RedirectToAction(nameof(CreateStructureOrganization));
            }

            return View();
        }

        public async Task<JsonResult> GetStructureOrganization(string data1a)//ajax calls this function which will return json object
        {
            if (data1a == "0")
            {
                var DataStructureOgranization = await Mediator.Send(new GetOrgChartByDepthByChartQuery());
                var bb = DataStructureOgranization.DataStructureCodeDs.ToList();
                return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }
            else
            {
                var DataStructureOgranization1 = await Mediator.Send(new GetOrgChartByParent2Query { Id = data1a });
                var bb = DataStructureOgranization1.DataOrgChartParent2DCs.ToList();
                return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }


        }


    }
}