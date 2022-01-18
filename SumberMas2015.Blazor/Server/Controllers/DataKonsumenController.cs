using MediatR;
using Microsoft.AspNetCore.Mvc;
using SumberMas2015.Blazor.Server.DtoMapping;
using SumberMas2015.Blazor.Shared.Dto.Agama;
using SumberMas2015.Blazor.Shared.Dto.DataKonsumen;
using SumberMas2015.Blazor.Shared.Dto.JenisKelamin;
using SumberMas2015.Blazor.Shared.Dto.MasterBidangUsaha;
using SumberMas2015.Blazor.Shared.Dto.NamaBidangPekerjaan;
using SumberMas2015.SalesMarketing.ServiceApplication.Agama.Queries.AgamaList;
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

        /// <summary>
        /// menampilkan list data bidang pekerjaan
        /// </summary>
        /// <returns>GetNamaBidangPekerjaanResponse</returns>
        [HttpGet("GetNamaBidangPekerjaanAsync")]
        public async Task<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>> GetNamaBidangPekerjaanAsync()
        {
            var listNamaBidangPekerjaan = await _mediator.Send(new GetNamaBidangPekerjaanQuery() );
            return listNamaBidangPekerjaan;
        }

        /// <summary>
        /// menampilkan list data Bidang usaha
        /// </summary>
        /// <returns>GetNamaBidangUsahaResponse</returns>
        [HttpGet("GetNamaBidangUsahaAsync")]
        public async Task<IReadOnlyCollection<GetNamaBidangUsahaResponse>> GetNamaBidangUsahaAsync()
        {
            var listNamaBidangUsaha = await _mediator.Send(new GetNamaBidangUsahaQuery());
            return listNamaBidangUsaha;
        }

        /// <summary>
        /// menampilkan list data jenis kelamin
        /// </summary>
        /// <returns>ListJenisKelaminResponse</returns>
        [HttpGet("GetJenisKelaminAsync")]
        public async Task<IReadOnlyCollection<ListJenisKelaminResponse>> GetJenisKelaminAsync()
        {
            var listJenisKelamin = await _mediator.Send(new ListJenisKelaminQuery());
            return listJenisKelamin;
        }

        /// <summary>
        /// menampilkan list data jenis kelamin
        /// </summary>
        /// <returns>ListJenisKelaminResponse</returns>
        public async Task<IReadOnlyCollection<AgamaListResponse>> GetAgamaListAsync()
        {
            var listAgama = await _mediator.Send(new AgamaListQuery());
            return listAgama;
        }


        /// <summary>
        /// CreateDataKonsumen action adalah untuk menginput data konsumen baru
        /// </summary>
        /// <param name="model">parameter inputan yang diperlukan</param>
        /// <returns>mengembalikan id dari hasil inputan</returns>
        /// <response code="201">return the newly created item</response>
        /// <response code="400">if the model is null</response>
        /// <remarks>
        /// sample request:
        ///      Post api/CreateDataKonsumenAsync
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
