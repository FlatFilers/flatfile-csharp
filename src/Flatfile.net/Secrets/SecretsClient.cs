using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SecretsClient
{
    private RawClient _client;

    public SecretsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Fetch all secrets for a given environmentId and optionally apply space overrides
    /// </summary>
    public async Task<SecretsResponse> ListAsync(ListSecrets request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.EnvironmentId != null)
        {
            _query["environmentId"] = request.EnvironmentId;
        }
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SecretsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Insert or Update a Secret by name for environment or space
    /// </summary>
    public async Task<SecretsResponse> UpsertAsync(WriteSecret request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SecretsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a specific Secret from the Environment or Space as is the case
    /// </summary>
    public async Task<SecretsResponse> DeleteAsync(string secretId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{secretId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SecretsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
