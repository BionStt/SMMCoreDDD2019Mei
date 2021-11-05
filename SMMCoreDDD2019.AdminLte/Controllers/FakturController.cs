using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.SalesMarketing.Dto.PermohonanBPKB;
using SumberMas2015.SalesMarketing.Dto.PermohonanFaktur;
using SumberMas2015.SalesMarketing.Dto.PermohonanSTNK;
using SumberMas2015.SalesMarketing.DtoMapping;
using SumberMas2015.SalesMarketing.ServiceApplication.Penjualan.Queries.GetNamaPenjualanFaktur;
using SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Queries.GetNamaFakturBPKB;
using SumberMas2015.SalesMarketing.ServiceApplication.PermohonanSTNK.Queries.GetNamaFakturStnk;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class FakturController : Controller
    {
        private IMediator _mediator;

        public FakturController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CreateMohonFaktur()
        {
            var NamaKonsumen1 = await _mediator.Send(new GetNamaPenjualanFakturQuery());

            ViewData["NamaKonsumen1"] = new SelectList(NamaKonsumen1, "NoPenjualanDetail", "NamaKonsumen1");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMohonFaktur(CreatePermohonanFakturRequest CreatePermohonanFakturCommand1)
        {
            if (ModelState.IsValid)
            {
                var xx = CreatePermohonanFakturCommand1.ToCommand();

                await _mediator.Send(xx);
                return RedirectToAction(nameof(FakturController.CreateMohonFaktur), "Faktur");

            }


            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateMohonSTNK()
        {
            var NamaKonsumen1 = await _mediator.Send(new GetNamaFakturStnkQuery());

            ViewData["NamaKonsumen1"] = new SelectList(NamaKonsumen1, "NoUrutFaktur1", "NamaFaktur");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMohonSTNK(CreatePermohonanSTNKRequest CreateSTNKDBCommand1)
        {
            if (ModelState.IsValid)
            {
                var xx = CreateSTNKDBCommand1.ToCommand();

                await _mediator.Send(xx);
                return RedirectToAction(nameof(FakturController.CreateMohonSTNK), "Faktur");

            }


            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateMohonBPKB()
        {
            var NamaKonsumen1 = await _mediator.Send(new GetNamaFakturBPKBQuery());

            ViewData["NamaKonsumen1"] = new SelectList(NamaKonsumen1, "NoUrutFaktur1", "NamaFaktur");

            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateMohonBPKB(CreatePermohonanBPKBRequest CreateBPKBDBCommand1)
        {
            if (ModelState.IsValid)
            {
                var xx = CreateBPKBDBCommand1.ToCommand();
                await _mediator.Send(xx);
                return RedirectToAction(nameof(FakturController.CreateMohonBPKB), "Faktur");

            }


            return View();

        }
    }
}
