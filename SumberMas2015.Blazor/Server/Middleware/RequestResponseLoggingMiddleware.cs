using System.Text;
using SumberMas2015.Blazor.Server.Models;

namespace SumberMas2015.Blazor.Server.Middleware
{
    public class RequestResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

        public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var requestId = context.TraceIdentifier;
            var startTime = DateTime.UtcNow;

            // Log request
            await LogRequest(context, requestId);

            // Capture response
            var originalBodyStream = context.Response.Body;
            using var memoryStream = new MemoryStream();
            context.Response.Body = memoryStream;

            try
            {
                await _next(context);
            }
            finally
            {
                // Log response
                await LogResponse(context, memoryStream, originalBodyStream, requestId, startTime);
            }
        }

        private async Task LogRequest(HttpContext context, string requestId)
        {
            var request = context.Request;
            var requestBody = string.Empty;

            if (request.ContentLength > 0 && request.ContentType?.Contains("application/json") == true)
            {
                request.EnableBuffering();
                using var reader = new StreamReader(request.Body, Encoding.UTF8, true, 1024, true);
                requestBody = await reader.ReadToEndAsync();
                request.Body.Position = 0;
            }

            var logMessage = new
            {
                RequestId = requestId,
                Timestamp = DateTime.UtcNow,
                Method = request.Method,
                Path = request.Path,
                QueryString = request.QueryString.ToString(),
                Headers = request.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()),
                Body = requestBody
            };

            _logger.LogInformation("Request: {@RequestLog}", logMessage);
        }

        private async Task LogResponse(HttpContext context, MemoryStream memoryStream, Stream originalBodyStream, string requestId, DateTime startTime)
        {
            var response = context.Response;
            var responseBody = string.Empty;

            memoryStream.Position = 0;
            responseBody = await new StreamReader(memoryStream).ReadToEndAsync();
            memoryStream.Position = 0;

            await memoryStream.CopyToAsync(originalBodyStream);
            context.Response.Body = originalBodyStream;

            var duration = DateTime.UtcNow - startTime;

            var logMessage = new
            {
                RequestId = requestId,
                Timestamp = DateTime.UtcNow,
                StatusCode = response.StatusCode,
                Duration = duration.TotalMilliseconds,
                Headers = response.Headers.ToDictionary(h => h.Key, h => h.Value.ToString()),
                Body = responseBody.Length > 1000 ? responseBody.Substring(0, 1000) + "..." : responseBody
            };

            _logger.LogInformation("Response: {@ResponseLog}", logMessage);
        }
    }
}
