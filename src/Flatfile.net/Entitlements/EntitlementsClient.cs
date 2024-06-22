using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EntitlementsClient
{
    private RawClient _client;

    public EntitlementsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all entitlements matching a filter for resourceId
    /// </summary>
    public async Task<ListEntitlementsResponse> ListAsync(ListEntitlementsRequest request)
    {
        var _query = new Dictionary<string, object>() { { "resourceId", request.ResourceId }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/entitlements",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListEntitlementsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
