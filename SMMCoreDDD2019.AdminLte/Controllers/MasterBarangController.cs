using MediatR;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.SalesMarketing.Dto.MasterBarang;
using SumberMas2015.SalesMarketing.DtoMapping;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class MasterBarangController : Controller
    {
        private IMediator _mediator;

        public MasterBarangController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMasterBarangRequest MasterBarangViewModel)
        {
            if (ModelState.IsValid)
            {
                var xx = MasterBarangViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(MasterBarangController.Create), "MasterBarang");
            }
            return View(MasterBarangViewModel);
        }
    }
}
