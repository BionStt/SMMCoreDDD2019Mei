using System.Net;
using System.Text.Json;

namespace SumberMas2015.Blazor.Server.Models
{
    public static class ApiErrorHandler
    {
        public static ApiResponse<T> HandleException<T>(Exception ex, string requestId, bool isDevelopment = false)
        {
            var response = new ApiResponse<T>
            {
                Success = false,
                RequestId = requestId,
                Timestamp = DateTime.UtcNow
            };

            switch (ex)
            {
                case HttpRequestException httpEx:
                    response.Message = "Network error occurred";
                    response.Errors.Add(httpEx.Message);
                    break;

                case JsonException jsonEx:
                    response.Message = "Invalid JSON response";
                    response.Errors.Add(jsonEx.Message);
                    break;

                case TaskCanceledException:
                    response.Message = "Request timeout";
                    response.Errors.Add("The request took too long to complete");
                    break;

                default:
                    response.Message = isDevelopment ? ex.Message : "An unexpected error occurred";
                    if (isDevelopment)
                    {
                        response.Errors.Add(ex.StackTrace);
                    }
                    break;
            }

            return response;
        }

        public static bool IsRetryableError(HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.RequestTimeout ||
                   statusCode == HttpStatusCode.InternalServerError ||
                   statusCode == HttpStatusCode.BadGateway ||
                   statusCode == HttpStatusCode.ServiceUnavailable ||
                   statusCode == HttpStatusCode.GatewayTimeout;
        }

        public static int GetRetryDelay(int attempt)
        {
            // Exponential backoff: 1s, 2s, 4s, 8s, 16s
            return Math.Min((int)Math.Pow(2, attempt), 30);
        }
    }
}
