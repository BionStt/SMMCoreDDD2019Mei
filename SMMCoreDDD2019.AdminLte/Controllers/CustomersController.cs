using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.UpdateCustomerDB;
using SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerByID;
using SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan;
using SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class CustomersController : Controller
    {
        private IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var NamaBidangPekerjaan1 = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await _mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateCustomerCommand customerViewModel)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(customerViewModel);
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
            var CustomerDb = await _mediator.Send(new GetCustomerByIDQuery { Id = id.ToString() });
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
                await _mediator.Send(CustomerDB);

                return RedirectToAction(nameof(Create));
            }
            return View(CustomerDB);
        }

    }
}
