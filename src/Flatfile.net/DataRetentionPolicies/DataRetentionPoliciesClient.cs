using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DataRetentionPoliciesClient
{
    private RawClient _client;

    public DataRetentionPoliciesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all data retention policies on an account matching a filter for environmentId
    /// </summary>
    public async Task<ListDataRetentionPoliciesResponse> ListAsync(
        ListDataRetentionPoliciesRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.EnvironmentId != null)
        {
            _query["environmentId"] = request.EnvironmentId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/data-retention-policies",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListDataRetentionPoliciesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Add a new data retention policy to the space
    /// </summary>
    public async Task<DataRetentionPolicyResponse> CreateAsync(DataRetentionPolicyConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/data-retention-policies",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DataRetentionPolicyResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single data retention policy
    /// </summary>
    public async Task<DataRetentionPolicyResponse> GetAsync(string id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/data-retention-policies/{id}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DataRetentionPolicyResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a single data retention policy
    /// </summary>
    public async Task<DataRetentionPolicyResponse> UpdateAsync(
        string id,
        DataRetentionPolicyConfig request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/data-retention-policies/{id}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DataRetentionPolicyResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a single data retention policy
    /// </summary>
    public async Task<Success> DeleteAsync(string id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/data-retention-policies/{id}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
