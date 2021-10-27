using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.Organization.Dto.DataPerusahaan;
using SumberMas2015.Organization.Dto.DataPerusahaanCabang;
using SumberMas2015.Organization.DtoMapping;
using SumberMas2015.Organization.ServiceApplication.DataPerusahaan.Queries.GetNamaPerusahaan;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class DataPerusahaanController : Controller
    {
        private IMediator _mediator;

        public DataPerusahaanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("DataPerusahaan/DataCabangCreate")]
        public async Task<IActionResult> DataCabangCreate()
        {
            var DataPerusahaan = await _mediator.Send(new GetNamaPerusahaanQuery());
            ViewData["NamaPerusahaan"] = new SelectList(DataPerusahaan, "IDPerusahaan", "NamaPerusahaan");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("DataPerusahaan/DataCabangCreate")]
        public async Task<IActionResult> DataCabangCreate(CreateDataPerusahaanCabangRequest DataPerusahaanCabangViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = DataPerusahaanCabangViewModel.ToCommand();
                await _mediator.Send(xx);
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
        public async Task<IActionResult> CreateDataPerusahaan(CreateDataPerusahaanRequest DataPerusahaanViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = DataPerusahaanViewModel.ToCommand();
                await _mediator.Send(DataPerusahaanViewModel);

                return RedirectToAction(nameof(DataPerusahaanController.DataCabangCreate), "DataPerusahaan");
            }
            return View(DataPerusahaanViewModel);
        }


        //public async Task<IActionResult> CreateStructureOrganization()
        //{
        //    var DataAccounting = await Mediator.Send(new GetOrgChartByParentCQuery());
        //    ViewData["DataAkun1"] = new SelectList(DataAccounting.DataOrgChartParentCDs.ToList(), "NoUrutStrukturID", "DataAkun1");
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateStructureOrganization(string KodeAccount1, string Parent1a, string Parent1, string Account1a, CreateDataPerusahaanOrgChartDBCommand CreateDataPerusahaanStrukturJabatanCommand1)
        //{
        //    string NilaiParent;
        //    if (Parent1 == "0")
        //    {
        //        NilaiParent = Parent1a;
        //    }
        //    else
        //    {
        //        NilaiParent = Parent1;

        //    };
        //    CreateDataPerusahaanStrukturJabatanCommand1.Parent = NilaiParent;
        //    CreateDataPerusahaanStrukturJabatanCommand1.KodeStrukturJabatan = KodeAccount1;
        //    CreateDataPerusahaanStrukturJabatanCommand1.NamaStrukturJabatan = Account1a;


        //    if (CreateDataPerusahaanStrukturJabatanCommand1 != null)
        //    {
        //        await Mediator.Send(CreateDataPerusahaanStrukturJabatanCommand1);
        //        return RedirectToAction(nameof(CreateStructureOrganization));
        //    }

        //    return View();
        //}

        //public async Task<JsonResult> GetStructureOrganization(string data1a)//ajax calls this function which will return json object
        //{
        //    if (data1a == "0")
        //    {
        //        var DataStructureOgranization = await Mediator.Send(new GetOrgChartByDepthByChartQuery());
        //        var bb = DataStructureOgranization.DataStructureCodeDs.ToList();
        //        return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
        //    }
        //    else
        //    {
        //        var DataStructureOgranization1 = await Mediator.Send(new GetOrgChartByParent2Query { Id = data1a });
        //        var bb = DataStructureOgranization1.DataOrgChartParent2DCs.ToList();
        //        return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
        //    }


        //}



    }
}
