using Shared;

namespace ObojeIntraktivity.Client;

public class ClientStringListService : IStringListService
{
    private readonly IStringListClient _client;

    public ClientStringListService(IStringListClient client)
    {
        _client = client;
    }

    public async Task<List<string>> GetStringList()
    {
        var result = await _client.GetListAsync();

        return result;
    }
}