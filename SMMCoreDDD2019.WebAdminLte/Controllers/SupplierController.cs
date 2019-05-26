using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.DeleteMasterSupplierDB;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.UpdateMasterSupplierDB;


namespace SMMCoreDDD2019.WebAdminLte.Controllers
{

    public class SupplierController : BaseController
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
        public async Task<IActionResult> Create(CreateMasterSupplierDBCommand SupplierViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(SupplierViewModel);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(SupplierViewModel);
        }


    }
}