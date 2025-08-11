using System.Net.Http.Json;
using System.Text.Json;
using SumberMas2015.Blazor.Shared.Dto;

namespace SumberMas2015.Blazor.Client.Services
{
    public interface IApiService
    {
        Task<ApiResponse<T>> GetAsync<T>(string endpoint);
        Task<ApiResponse<T>> PostAsync<T>(string endpoint, object data);
        Task<ApiResponse<T>> PutAsync<T>(string endpoint, object data);
        Task<ApiResponse<T>> DeleteAsync<T>(string endpoint);
    }

    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ApiService> _logger;
        private readonly JsonSerializerOptions _jsonOptions;

        public ApiService(HttpClient httpClient, ILogger<ApiService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string endpoint)
        {
            return await ExecuteWithRetryAsync(async () =>
            {
                var response = await _httpClient.GetAsync(endpoint);
                return await HandleResponseAsync<T>(response);
            });
        }

        public async Task<ApiResponse<T>> PostAsync<T>(string endpoint, object data)
        {
            return await ExecuteWithRetryAsync(async () =>
            {
                var response = await _httpClient.PostAsJsonAsync(endpoint, data, _jsonOptions);
                return await HandleResponseAsync<T>(response);
            });
        }

        public async Task<ApiResponse<T>> PutAsync<T>(string endpoint, object data)
        {
            return await ExecuteWithRetryAsync(async () =>
            {
                var response = await _httpClient.PutAsJsonAsync(endpoint, data, _jsonOptions);
                return await HandleResponseAsync<T>(response);
            });
        }

        public async Task<ApiResponse<T>> DeleteAsync<T>(string endpoint)
        {
            return await ExecuteWithRetryAsync(async () =>
            {
                var response = await _httpClient.DeleteAsync(endpoint);
                return await HandleResponseAsync<T>(response);
            });
        }

        private async Task<ApiResponse<T>> ExecuteWithRetryAsync<T>(Func<Task<ApiResponse<T>>> operation)
        {
            const int maxRetries = 3;
            var attempt = 0;

            while (attempt < maxRetries)
            {
                try
                {
                    return await operation();
                }
                catch (HttpRequestException ex) when (attempt < maxRetries - 1)
                {
                    attempt++;
                    var delay = Math.Min((int)Math.Pow(2, attempt), 30);
                    _logger.LogWarning(ex, "API request failed, retrying in {Delay} seconds. Attempt {Attempt}/{MaxRetries}", 
                        delay, attempt, maxRetries);
                    await Task.Delay(delay * 1000);
                }
                catch (TaskCanceledException ex) when (attempt < maxRetries - 1)
                {
                    attempt++;
                    var delay = Math.Min((int)Math.Pow(2, attempt), 30);
                    _logger.LogWarning(ex, "API request timeout, retrying in {Delay} seconds. Attempt {Attempt}/{MaxRetries}", 
                        delay, attempt, maxRetries);
                    await Task.Delay(delay * 1000);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "API request failed permanently");
                    return new ApiResponse<T>
                    {
                        Success = false,
                        Message = "Request failed",
                        Errors = new List<string> { ex.Message }
                    };
                }
            }

            return new ApiResponse<T>
            {
                Success = false,
                Message = "Request failed after multiple attempts",
                Errors = new List<string> { "Maximum retry attempts exceeded" }
            };
        }

        private async Task<ApiResponse<T>> HandleResponseAsync<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var result = JsonSerializer.Deserialize<ApiResponse<T>>(content, _jsonOptions);
                    return result ?? new ApiResponse<T>
                    {
                        Success = false,
                        Message = "Invalid response format",
                        Errors = new List<string> { "Response could not be deserialized" }
                    };
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Failed to deserialize response: {Content}", content);
                    return new ApiResponse<T>
                    {
                        Success = false,
                        Message = "Invalid response format",
                        Errors = new List<string> { ex.Message }
                    };
                }
            }
            else
            {
                try
                {
                    var errorResponse = JsonSerializer.Deserialize<ApiResponse<object>>(content, _jsonOptions);
                    return new ApiResponse<T>
                    {
                        Success = false,
                        Message = errorResponse?.Message ?? $"HTTP {response.StatusCode}",
                        Errors = errorResponse?.Errors ?? new List<string> { response.ReasonPhrase ?? "Unknown error" }
                    };
                }
                catch
                {
                    return new ApiResponse<T>
                    {
                        Success = false,
                        Message = $"HTTP {response.StatusCode}",
                        Errors = new List<string> { response.ReasonPhrase ?? "Unknown error" }
                    };
                }
            }
        }
    }
}
