using MediatR;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Blazor.Server.DtoMapping;
using SumberMas2015.Blazor.Shared.Dto.DataKonsumen;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;
using SumberMas2015.Blazor.Shared.Dto.MasterBidangUsaha;
using SumberMas2015.Blazor.Shared.Dto.NamaBidangPekerjaan;
using SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelamin;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries;
using System.Security.Claims;

namespace SumberMas2015.Blazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataKonsumenController : ControllerBase
    {
        private readonly ILogger<DataKonsumenController> _logger;
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;

        public DataKonsumenController(ILogger<DataKonsumenController> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _logger=logger;

            _httpContextAccessor=httpContextAccessor;
            _mediator=mediator;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;//userID Guid

            //  _userName = httpContextAccessor.HttpContext.User.Identity.Name;//username
            // _userId2 =  httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;//UserNAme

        }
        [HttpGet("GetNamaBidangPekerjaanAsync")]
        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> GetNamaBidangPekerjaanAsync()
        {
            var listNamaBidangPekerjaan = await _mediator.Send(new GetNamaBidangPekerjaanQuery() );
            return listNamaBidangPekerjaan;
        }
        [HttpGet("GetNamaBidangUsahaAsync")]
        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> GetNamaBidangUsahaAsync()
        {
            var listNamaBidangUsaha = await _mediator.Send(new GetNamaBidangUsahaQuery());
            return listNamaBidangUsaha;
        }
        public async Task<IReadOnlyCollection<ListJenisKelaminResponse>> GetJenisKelaminAsync()
        {
            var listJenisKelamin = await _mediator.Send(new ListJenisKelaminQuery());
            return listJenisKelamin;
        }
        //public async Task<IActionResult> Create()
        //{
        //    var NamaBidangPekerjaan1 = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
        //    var NamaBidangUsaha1 = await _mediator.Send(new GetNamaBidangUsahaQuery());
        //    ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
        //    ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

        //    var Agama = await _mediator.Send(new AgamaListQuery());
        //    var JnsKelamin = await _mediator.Send(new ListJenisKelaminQuery());
        //    ViewData["Agama1"] = new SelectList(Agama, "NoUrutId", "AgamaKeterangan");
        //    ViewData["JnsKelamin1"] = new SelectList(JnsKelamin, "NoUrutId", "JenisKelaminKeterangan");

        //    ViewData["UserId"] = _userId;

        //    //  ViewData["UserId2"] = _userId2;
        //    //  ViewData["UserName"] = _userName;

        //    return View();
        //}

        /// <summary>
        /// CreateDataKonsumen action adalah untuk menginput data konsumen baru
        /// </summary>
        /// <param name="model">parameter inputan yang diperlukan</param>
        /// <returns>mengembalikan id dari hasil inputan</returns>
        /// <response code="201">return the newly created item</response>
        /// <response code="400">if the model is null</response>
        /// <remarks>
        /// sample request:
        ///      Post api/CreateDataKonsumen
        ///      {
        ///         "NamaDepan":" bion",
        /// 
        ///      }
        /// </remarks>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [Produces("application/json")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKonsumenAsync(CreateDataKonsumenRequest customerViewModel)
        {
            var dtKonsumen = customerViewModel.ToCommand();
            var aa = await _mediator.Send(dtKonsumen);
            
            return Created(nameof(this.CreateDataKonsumenAsync), aa);
        }

    }
}
