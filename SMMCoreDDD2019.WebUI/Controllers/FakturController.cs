using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.BPKBDBs.Command.CreateBPKBDB;
using SmmCoreDDD2019.Application.Penjualans.Query.GetNamaPenjualanFaktur;
using SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.CreatePermohonanFaktur;
using SmmCoreDDD2019.Application.STNKDBs.Command.CreateSTNKDB;
using SmmCoreDDD2019.Application.STNKDBs.Query.GetNamaFakturBPKB;
using SmmCoreDDD2019.Application.STNKDBs.Query.GetNamaFakturStnk;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class FakturController : BaseController
    {
      

        [HttpGet]
        public async Task<IActionResult> CreateMohonFaktur()
        {
            var NamaKonsumen1 = await Mediator.Send(new GetNamaPenjualanFakturQuery());
         
            ViewData["NamaKonsumen1"] = new SelectList(NamaKonsumen1.DataPenjualanFakturDs, "NoPenjualanDetail", "NamaKonsumen1");
        
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMohonFaktur(CreatePermohonanFakturCommand CreatePermohonanFakturCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreatePermohonanFakturCommand1);
                return RedirectToAction(nameof(FakturController.CreateMohonFaktur), "Faktur");

            }


                return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateMohonSTNK()
        {
            var NamaKonsumen1 = await Mediator.Send(new GetNamaFakturStnkQuery());

            ViewData["NamaKonsumen1"] = new SelectList(NamaKonsumen1.DataFakturStnkDs, "NoUrutFaktur1", "NamaFaktur");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMohonSTNK(CreateSTNKDBCommand CreateSTNKDBCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateSTNKDBCommand1);
                return RedirectToAction(nameof(FakturController.CreateMohonSTNK), "Faktur");

            }


            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateMohonBPKB()
        {
            var NamaKonsumen1 = await Mediator.Send(new GetNamaFakturBPKBQuery());

            ViewData["NamaKonsumen1"] = new SelectList(NamaKonsumen1.DataFakturBPKBDs, "NoUrutFaktur1", "NamaFaktur");

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateMohonBPKB(CreateBPKBDBCommand CreateBPKBDBCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateBPKBDBCommand1);
                return RedirectToAction(nameof(FakturController.CreateMohonBPKB), "Faktur");

            }


            return View();

        }




    }
}