using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using SumberMas2015.Blazor.Server.Models;
using System.Security.Claims;

namespace SumberMas2015.Blazor.Server.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [EnableRateLimiting("AuthenticatedUser")]
    public abstract class BaseApiController : ControllerBase
    {
        protected readonly ILogger _logger;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected readonly string _userId;
        protected readonly string _userName;

        protected BaseApiController(ILogger logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            
            var user = httpContextAccessor.HttpContext?.User;
            _userId = user?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
            _userName = user?.Identity?.Name ?? string.Empty;
        }

        protected ActionResult<ApiResponse<T>> SuccessResponse<T>(T data, string message = "Success")
        {
            var response = ApiResponse<T>.SuccessResult(data, message);
            response.RequestId = HttpContext.TraceIdentifier;
            return Ok(response);
        }

        protected ActionResult<ApiResponse<T>> CreatedResponse<T>(T data, string message = "Created successfully")
        {
            var response = ApiResponse<T>.SuccessResult(data, message);
            response.RequestId = HttpContext.TraceIdentifier;
            return Created(string.Empty, response);
        }

        protected ActionResult<ApiResponse<T>> BadRequestResponse<T>(string message, List<string> errors = null)
        {
            var response = ApiResponse<T>.ErrorResult(message, errors);
            response.RequestId = HttpContext.TraceIdentifier;
            return BadRequest(response);
        }

        protected ActionResult<ApiResponse<T>> NotFoundResponse<T>(string message = "Resource not found")
        {
            var response = ApiResponse<T>.ErrorResult(message);
            response.RequestId = HttpContext.TraceIdentifier;
            return NotFound(response);
        }

        protected ActionResult<ApiResponse<T>> UnauthorizedResponse<T>(string message = "Unauthorized")
        {
            var response = ApiResponse<T>.ErrorResult(message);
            response.RequestId = HttpContext.TraceIdentifier;
            return Unauthorized(response);
        }

        protected ActionResult<ApiResponse<T>> InternalServerErrorResponse<T>(string message = "Internal server error")
        {
            var response = ApiResponse<T>.ErrorResult(message);
            response.RequestId = HttpContext.TraceIdentifier;
            return StatusCode(500, response);
        }
    }
}
