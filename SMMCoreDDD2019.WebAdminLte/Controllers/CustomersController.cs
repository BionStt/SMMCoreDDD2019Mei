using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;

using SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.DeleteCustomerDB;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.UpdateCustomerDB;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBDetail;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBList;
using Microsoft.AspNetCore.Authorization;
using SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan;
using SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID;


namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class CustomersController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var NamaBidangPekerjaan1 = await Mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await Mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1.MasterBidangPekerjaanDs, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1.MasterBidangUsahaDs, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCustomerCommand customerViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(customerViewModel);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(customerViewModel);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> EditCustomer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var CustomerDb = await Mediator.Send(new GetCustomerByIDQuery { Id = id.ToString() });
            if (CustomerDb == null)
            {
                return NotFound();
            }
            return View(CustomerDb);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomer(int id, UpdateCustomerCommand CustomerDB)
        {
            if (id != CustomerDB.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await Mediator.Send(CustomerDB);

                return RedirectToAction(nameof(Create));
            }
            return View(CustomerDB);
        }





    }
}