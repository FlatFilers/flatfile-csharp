using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RolesClient
{
    private RawClient _client;

    public RolesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// List all roles for an account
    /// </summary>
    public async Task<ListRolesResponse> ListAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = "/roles" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListRolesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
