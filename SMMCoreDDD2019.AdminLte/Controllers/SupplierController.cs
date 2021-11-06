using MediatR;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Inventory.Dto;
using SumberMas2015.Inventory.DtoMapping;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class SupplierController : Controller
    {
        private IMediator _mediator;

        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public   IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateSupplierRequest SupplierViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = SupplierViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(SupplierViewModel);
        }


    }
}
