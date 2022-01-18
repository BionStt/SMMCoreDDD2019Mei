using MediatR;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Blazor.Server.DtoMapping;
using SumberMas2015.Blazor.Shared.Dto.MasterBarang;
using System.Security.Claims;

namespace SumberMas2015.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterBarangController : ControllerBase
    {
        private readonly ILogger<DataKonsumenController> _logger;
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;
        private readonly string _userName;
        public MasterBarangController(ILogger<DataKonsumenController> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _logger=logger;
            _mediator=mediator;
            _httpContextAccessor = httpContextAccessor;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;//userID Guid
            _userName = httpContextAccessor.HttpContext.User.Identity.Name;
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(CreateMasterBarangRequest MasterBarangViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        MasterBarangViewModel.UserId=_userId;

        //        var xx = MasterBarangViewModel.ToCommand();
        //        await _mediator.Send(xx);

        //        return RedirectToAction(nameof(MasterBarangController.Create), "MasterBarang");
        //    }
        //    return View(MasterBarangViewModel);
        //}
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateMasterBarang(CreateMasterBarangRequest MasterBarangViewModel)
        {
            MasterBarangViewModel.UserId=_userId;

                   var xx = MasterBarangViewModel.ToCommand();
                    var cc = await _mediator.Send(xx);
            return Created(nameof(this.CreateMasterBarang), cc);

        }

     
    }
}
