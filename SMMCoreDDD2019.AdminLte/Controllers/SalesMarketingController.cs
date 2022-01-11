using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.SalesMarketing.Dto.SalesMarketing;
using SumberMas2015.SalesMarketing.DtoMapping;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class SalesMarketingController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;
        private readonly string _userName;

        public SalesMarketingController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {   
            _userName = httpContextAccessor.HttpContext.User.Identity.Name;//username
            _userId =  httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;//UserNAme
            _mediator=mediator;
            _httpContextAccessor=httpContextAccessor;

        }

        public IActionResult AddSalesMarketing()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSalesMarketing(SalesMarketingRequest salesMarketingRequest)
        {

            if (ModelState.IsValid)
            {
                salesMarketingRequest.SalesMarketingId = System.Guid.NewGuid();
                var dtSalesMarketing = salesMarketingRequest.ToCommand();
                await _mediator.Send(dtSalesMarketing);


           
             //   return RedirectToAction(nameof(HomeController.Index), "Home");
                return RedirectToAction(nameof(SalesMarketingController.AddSalesMarketing), "SalesMarketing"); //kmn gitu
            }

                return View(salesMarketingRequest);
        }
    }
}
