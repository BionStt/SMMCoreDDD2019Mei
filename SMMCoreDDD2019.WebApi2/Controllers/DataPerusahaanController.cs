using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByStructureCode;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByParent2;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Query.GetStructureByParentC;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.DataPerusahaanStrukturJabatanDBs.Command.CreateDataPerusahaanStrukturJabatan;

namespace SMMCoreDDD2019.WebApi2.Controllers
{
    public class DataPerusahaanController : BaseController
    {
        //public async Task<JsonResult> GetStructureOrganization(string data1a)//ajax calls this function which will return json object

        //{
        //    if (data1a == "0")
        //    {
        //        var DataStructureOgranization = await Mediator.Send(new GetStructureByStructureCodeQuery());
        //        var bb = DataStructureOgranization.DataStructureCodeDs.ToList();
        //        return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
        //    }
        //    else
        //    {
        //        var DataStructureOgranization1 = await Mediator.Send(new GetStructureByParent2Query { Id = data1a });
        //        var bb = DataStructureOgranization1.DataStructureParent2DCs.ToList();
        //        return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
        //    }


        //}

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //public async Task<IActionResult> CreateStructureOrganization()
        //{
        //    return Ok(await Mediator.Send(new GetStructureByParentCQuery()));
        //    //var DataAccounting = await Mediator.Send(new GetStructureByParentCQuery());
        //    //ViewData["DataAkun1"] = new SelectList(DataAccounting.StructureDataParentCDs.ToList(), "NoUrutStrukturID", "DataAkun1");
        //    //return View();
        //}
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreateDataPerusahaanStrukturJabatanCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateStructureOrganization(string KodeAccount1, string Parent1a, string Parent1, string Account1a, CreateDataPerusahaanStrukturJabatanCommand CreateDataPerusahaanStrukturJabatanCommand1)
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
        //    CreateDataPerusahaanStrukturJabatanCommand1.KodeStruktur = KodeAccount1;
        //    CreateDataPerusahaanStrukturJabatanCommand1.NamaStrukturJabatan = Account1a;


        //    if (CreateDataPerusahaanStrukturJabatanCommand1 != null)
        //    {
        //        await Mediator.Send(CreateDataPerusahaanStrukturJabatanCommand1);
        //        return RedirectToAction(nameof(CreateStructureOrganization));
        //    }

        //    return View();
        //}


    }
}