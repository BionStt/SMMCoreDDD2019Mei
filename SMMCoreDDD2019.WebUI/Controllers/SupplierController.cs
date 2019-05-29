﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

using Microsoft.AspNetCore.Authorization;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.CreateMasterSupplierDB;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.DeleteMasterSupplierDB;
using SmmCoreDDD2019.Application.MasterSupplierDBs.Commands.UpdateMasterSupplierDB;

//using SmmCoreDDD2019.Application.MasterSupplierDBs.Queries.GetCustomerDBDetail;
//using SmmCoreDDD2019.Application.MasterSupplierDBs.Queries.GetCustomerDBList;

namespace SMMCoreDDD2019.WebUI.Controllers
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