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
using SumberMas2015.Blazor.Server.Models;

namespace SumberMas2015.Blazor.Server.Controllers
{
    public class DataKonsumenController : BaseApiController
    {
        private readonly IMediator _mediator;
       
        public DataKonsumenController(ILogger<DataKonsumenController> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
            : base(logger, httpContextAccessor)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get list of job fields
        /// </summary>
        /// <returns>List of job fields</returns>
        /// <response code="200">Returns the list of job fields</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("GetNamaBidangPekerjaanAsync")]
        [ProducesResponseType(typeof(ApiResponse<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>), 200)]
        [ProducesResponseType(typeof(ApiResponse<object>), 500)]
        public async Task<ActionResult<ApiResponse<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>>> GetNamaBidangPekerjaanAsync()
        {
            try
            {
                var listNamaBidangPekerjaan = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
                return SuccessResponse(listNamaBidangPekerjaan, "Job fields retrieved successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving job fields");
                return InternalServerErrorResponse<IReadOnlyCollection<GetNamaBidangPekerjaanResponse>>("Failed to retrieve job fields");
            }
        }

        /// <summary>
        /// Get list of business fields
        /// </summary>
        /// <returns>List of business fields</returns>
        /// <response code="200">Returns the list of business fields</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("GetNamaBidangUsahaAsync")]
        [ProducesResponseType(typeof(ApiResponse<IReadOnlyCollection<GetNamaBidangUsahaResponse>>), 200)]
        [ProducesResponseType(typeof(ApiResponse<object>), 500)]
        public async Task<ActionResult<ApiResponse<IReadOnlyCollection<GetNamaBidangUsahaResponse>>>> GetNamaBidangUsahaAsync()
        {
            try
            {
                var listNamaBidangUsaha = await _mediator.Send(new GetNamaBidangUsahaQuery());
                return SuccessResponse(listNamaBidangUsaha, "Business fields retrieved successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving business fields");
                return InternalServerErrorResponse<IReadOnlyCollection<GetNamaBidangUsahaResponse>>("Failed to retrieve business fields");
            }
        }

        /// <summary>
        /// Get list of gender types
        /// </summary>
        /// <returns>List of gender types</returns>
        /// <response code="200">Returns the list of gender types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("GetJenisKelaminAsync")]
        [ProducesResponseType(typeof(ApiResponse<IReadOnlyCollection<ListJenisKelaminResponse>>), 200)]
        [ProducesResponseType(typeof(ApiResponse<object>), 500)]
        public async Task<ActionResult<ApiResponse<IReadOnlyCollection<ListJenisKelaminResponse>>>> GetJenisKelaminAsync()
        {
            try
            {
                var listJenisKelamin = await _mediator.Send(new ListJenisKelaminQuery());
                return SuccessResponse(listJenisKelamin, "Gender types retrieved successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving gender types");
                return InternalServerErrorResponse<IReadOnlyCollection<ListJenisKelaminResponse>>("Failed to retrieve gender types");
            }
        }

        /// <summary>
        /// Get list of religions
        /// </summary>
        /// <returns>List of religions</returns>
        /// <response code="200">Returns the list of religions</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("GetAgamaListAsync")]
        [ProducesResponseType(typeof(ApiResponse<IReadOnlyCollection<AgamaListResponse>>), 200)]
        [ProducesResponseType(typeof(ApiResponse<object>), 500)]
        public async Task<ActionResult<ApiResponse<IReadOnlyCollection<AgamaListResponse>>>> GetAgamaListAsync()
        {
            try
            {
                var listAgama = await _mediator.Send(new AgamaListQuery());
                return SuccessResponse(listAgama, "Religions retrieved successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving religions");
                return InternalServerErrorResponse<IReadOnlyCollection<AgamaListResponse>>("Failed to retrieve religions");
            }
        }


        /// <summary>
        /// Creates a new customer data
        /// </summary>
        /// <param name="request">The customer creation request</param>
        /// <returns>Created customer with ID</returns>
        /// <response code="201">Returns the newly created customer</response>
        /// <response code="400">If the request is invalid</response>
        /// <response code="401">If the user is not authenticated</response>
        /// <response code="500">If there was an internal server error</response>
        /// <remarks>
        /// Sample request:
        ///     POST api/v1/DataKonsumen/CreateDataKonsumenAsync
        ///     {
        ///         "sortColumn": "",
        ///         "sortColumnDir": "",
        ///         "pageNumber": 1,
        ///         "pageSize": 10,
        ///         "searchParam": "",
        ///         "groupId": "",
        ///         "groupIdName": "",
        ///         "parentId": "",
        ///         "parentIdName": "",
        ///         "clientId": 0,
        ///         "leadsId": 0,
        ///         "memoId": ""
        ///     }
        /// </remarks>
        [HttpPost("CreateDataKonsumenAsync")]
        [ProducesResponseType(typeof(ApiResponse<object>), 201)]
        [ProducesResponseType(typeof(ApiResponse<object>), 400)]
        [ProducesResponseType(typeof(ApiResponse<object>), 401)]
        [ProducesResponseType(typeof(ApiResponse<object>), 500)]
        public async Task<ActionResult<ApiResponse<object>>> CreateDataKonsumenAsync(CreateDataKonsumenRequest request)
        {
            try
            {
                var command = request.ToCommand();
                var result = await _mediator.Send(command);
                
                return CreatedResponse(result, "Customer created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating customer for user {UserId}", _userId);
                return InternalServerErrorResponse<object>("Failed to create customer");
            }
        }

    }
}
