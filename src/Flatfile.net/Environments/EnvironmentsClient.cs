using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EnvironmentsClient
{
    private RawClient _client;

    public EnvironmentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all environments
    /// </summary>
    public async Task<ListEnvironmentsResponse> ListAsync(ListEnvironmentsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize;
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber;
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
            return JsonSerializer.Deserialize<ListEnvironmentsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create a new environment
    /// </summary>
    public async Task<EnvironmentResponse> CreateAsync(EnvironmentConfigCreate request)
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
            return JsonSerializer.Deserialize<EnvironmentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a token which can be used to subscribe to events for this environment
    /// </summary>
    public async Task<EventTokenResponse> GetEnvironmentEventTokenAsync(
        GetEnvironmentEventTokenRequest request
    )
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/subscription-token",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EventTokenResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single environment
    /// </summary>
    public async Task<EnvironmentResponse> GetAsync(string environmentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{environmentId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EnvironmentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a single environment, to change the name for example
    /// </summary>
    public async Task<Environment> UpdateAsync(
        string environmentId,
        EnvironmentConfigUpdate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/{environmentId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Environment>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a single environment
    /// </summary>
    public async Task<Success> DeleteAsync(string environmentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{environmentId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
