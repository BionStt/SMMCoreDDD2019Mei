using MediatR;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Blazor.Server.DtoMapping;
using SumberMas2015.Blazor.Shared.Dto.MasterBarang;
using SumberMas2015.Blazor.Server.Models;

namespace SumberMas2015.Blazor.Server.Controllers
{
    public class MasterBarangController : BaseApiController
    {
        private readonly IMediator _mediator;
        
        public MasterBarangController(ILogger<MasterBarangController> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
            : base(logger, httpContextAccessor)
        {
            _mediator = mediator;
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
        /// <summary>
        /// Creates a new master barang (product)
        /// </summary>
        /// <param name="request">The master barang creation request</param>
        /// <returns>Created master barang with ID</returns>
        /// <response code="201">Returns the newly created master barang</response>
        /// <response code="400">If the request is invalid</response>
        /// <response code="401">If the user is not authenticated</response>
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse<object>), 201)]
        [ProducesResponseType(typeof(ApiResponse<object>), 400)]
        [ProducesResponseType(typeof(ApiResponse<object>), 401)]
        public async Task<ActionResult<ApiResponse<object>>> CreateMasterBarang(CreateMasterBarangRequest request)
        {
            try
            {
                request.UserId = _userId;
                var command = request.ToCommand();
                var result = await _mediator.Send(command);
                
                return CreatedResponse(result, "Master barang created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating master barang for user {UserId}", _userId);
                return InternalServerErrorResponse<object>("Failed to create master barang");
            }
        }

     
    }
}
