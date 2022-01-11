using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Inventory.Dto.MasterBarang;
using SumberMas2015.Inventory.DtoMapping;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class MasterBarangController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;
        private readonly string _userName;
        public MasterBarangController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;//userID Guid
            _userName = httpContextAccessor.HttpContext.User.Identity.Name;
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["UserId"] = _userId;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMasterBarangRequest MasterBarangViewModel)
        {
            if (ModelState.IsValid)
            {
                MasterBarangViewModel.UserId=_userId;
                
                var xx = MasterBarangViewModel.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(MasterBarangController.Create), "MasterBarang");
            }
            return View(MasterBarangViewModel);
        }
    }
}
