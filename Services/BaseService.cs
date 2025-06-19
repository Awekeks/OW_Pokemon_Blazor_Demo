
using System.Net.Http.Json;

namespace Services;

public class BaseService
{
    protected readonly HttpClient _httpClient;

    public BaseService(string baseUrl)
    {
        _httpClient = new HttpClient() { BaseAddress = new Uri(baseUrl) };
    }

    protected async Task<T?> GetAsync<T>(string url, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.GetAsync(url, cancellationToken);
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken);
    }
}