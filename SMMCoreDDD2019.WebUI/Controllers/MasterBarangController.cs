using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.MasterBarangDBs.Commands.CreateMasterBarangDB;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMasterBarangByID;
using SmmCoreDDD2019.Application.MasterBarangDBs.Commands.UpdateMasterBarangDBs;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class MasterBarangController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMasterBarangDBCommand MasterBarangViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(MasterBarangViewModel);

                return RedirectToAction(nameof(MasterBarangController.Create), "MasterBarang");
            }
            return View(MasterBarangViewModel);
        }
        // GET: Customers/Edit/5
        public async Task<IActionResult> EditMasterBarang(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var MasterBarang = await Mediator.Send(new GetMasterBarangByIDQuery{Id=id.ToString() });
            if (MasterBarang == null)
            {
                return NotFound();
            }
            return View(MasterBarang);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMasterBarang(int id, UpdateMasterBarangDBCommand MasterBarang1)
        {
            if (id != MasterBarang1.NoUrutTypeKendaraan)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await Mediator.Send(MasterBarang1);
               
                return RedirectToAction(nameof(Index));
            }
            return View(MasterBarang1);
        }



    }
}