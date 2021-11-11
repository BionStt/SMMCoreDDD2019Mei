using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Inventory.Dto;
using SumberMas2015.Inventory.DtoMapping;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class SupplierController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;

        public SupplierController(IMediator mediator, IHttpContextAccessor httpContextAccessor = null)
        {
            _mediator = mediator;
            _httpContextAccessor=httpContextAccessor;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
        [HttpGet]
        public   IActionResult Create()
        {
            ViewData["UserId"] = _userId;
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
