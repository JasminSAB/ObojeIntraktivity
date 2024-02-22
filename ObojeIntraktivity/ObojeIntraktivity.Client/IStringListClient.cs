using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ObojeIntraktivity.Client;

public interface IStringListClient
{
    Task<List<string>> GetListAsync();
}

public class StringListClient : IStringListClient
{
    private HttpClient _httpClient;

    public StringListClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<string>> GetListAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, _httpClient.BaseAddress + "api/test");
        request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

        using var response = await _httpClient.SendAsync(request, CancellationToken.None);

        var result = await response.Content.ReadFromJsonAsync<List<string>>();

        return result;
    }
}