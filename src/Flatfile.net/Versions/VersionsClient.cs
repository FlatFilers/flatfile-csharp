using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class VersionsClient
{
    private RawClient _client;

    public VersionsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<VersionResponse> CreateIdAsync(VersionsPostRequestBody request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/versions",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<VersionResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
