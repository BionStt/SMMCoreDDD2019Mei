using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.SalesMarketing.Dto.MasterLeasing;
using SumberMas2015.SalesMarketing.DtoMapping;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class LeasingController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userName;
        private readonly string _userId;

        public LeasingController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator=mediator;
            _httpContextAccessor=httpContextAccessor;
            _userName = httpContextAccessor.HttpContext.User.Identity.Name;//dapatnya nama
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value; //dapatnya guid
        }

        public IActionResult CreateMasterLeasing()
        {
            ViewData["UserName"] = _userName;
            ViewData["UserId"] = _userId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMasterLeasing(CreateMasterLeasingRequest createMasterLeasingRequest)
        {
            if (ModelState.IsValid)
            {
                var xx = createMasterLeasingRequest.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(LeasingController.CreateMasterLeasing), "MasterLeasing"); //kmn gitu
            }

                return View(createMasterLeasingRequest);
        }
        public IActionResult CreateMasterLeasingCabang()
        {
            ViewData["UserName"] = _userName;
            ViewData["UserId"] = _userId;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMasterLeasingCabang(CreateMasterLeasingCabangRequest createMasterLeasingCabangRequest)
        {
            if (ModelState.IsValid)
            {
                var xx = createMasterLeasingCabangRequest.ToCommand();
                await _mediator.Send(xx);

                return RedirectToAction(nameof(LeasingController.CreateMasterLeasingCabang), "MasterLeasingCabang"); //kmn gitu
            }

            return View(createMasterLeasingCabangRequest);
        }
    }
}
