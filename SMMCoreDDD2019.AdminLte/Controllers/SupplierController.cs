using MediatR;
using Microsoft.AspNetCore.Mvc;
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
