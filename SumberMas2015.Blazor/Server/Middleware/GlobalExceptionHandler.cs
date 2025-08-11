using System.Net;
using System.Text.Json;
using SumberMas2015.Blazor.Server.Models;

namespace SumberMas2015.Blazor.Server.Middleware
{
    public class GlobalExceptionHandler : IMiddleware
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;
        private readonly IWebHostEnvironment _environment;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var requestId = context.TraceIdentifier;
            var response = context.Response;
            response.ContentType = "application/json";

            var errorResponse = new ApiResponse<object>
            {
                Success = false,
                RequestId = requestId,
                Timestamp = DateTime.UtcNow
            };

            switch (exception)
            {
                case ArgumentException argEx:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    errorResponse.Message = "Invalid argument provided";
                    errorResponse.Errors.Add(argEx.Message);
                    break;

                case UnauthorizedAccessException:
                    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    errorResponse.Message = "Unauthorized access";
                    break;

                case InvalidOperationException invOpEx:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    errorResponse.Message = "Invalid operation";
                    errorResponse.Errors.Add(invOpEx.Message);
                    break;

                case KeyNotFoundException keyEx:
                    response.StatusCode = (int)HttpStatusCode.NotFound;
                    errorResponse.Message = "Resource not found";
                    errorResponse.Errors.Add(keyEx.Message);
                    break;

                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    errorResponse.Message = _environment.IsDevelopment() 
                        ? exception.Message 
                        : "An unexpected error occurred";
                    
                    if (_environment.IsDevelopment())
                    {
                        errorResponse.Errors.Add(exception.StackTrace);
                    }
                    break;
            }

            // Log the exception
            _logger.LogError(exception, "Request {RequestId} failed: {Message}", requestId, exception.Message);

            var result = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await response.WriteAsync(result);
        }
    }
}
