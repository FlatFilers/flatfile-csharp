using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class MappingClient
{
    private RawClient _client;

    public MappingClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a list of mapping rules based on two provided schemas
    /// </summary>
    public async Task<ProgramResponse> CreateMappingProgramAsync(ProgramConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/mapping",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ProgramResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes all history for the authenticated user
    /// </summary>
    public async Task<Success> DeleteAllHistoryForUserAsync(DeleteAllHistoryForUserRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = "/mapping",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// List all mapping programs
    /// </summary>
    public async Task<ProgramsResponse> ListMappingProgramsAsync(ListProgramsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize.ToString();
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber.ToString();
        }
        if (request.CreatedBy != null)
        {
            _query["createdBy"] = request.CreatedBy;
        }
        if (request.CreatedAfter != null)
        {
            _query["createdAfter"] = request.CreatedAfter.Value.ToString("o0");
        }
        if (request.CreatedBefore != null)
        {
            _query["createdBefore"] = request.CreatedBefore.Value.ToString("o0");
        }
        if (request.EnvironmentId != null)
        {
            _query["environmentId"] = request.EnvironmentId;
        }
        if (request.FamilyId != null)
        {
            _query["familyId"] = request.FamilyId;
        }
        if (request.Namespace != null)
        {
            _query["namespace"] = request.Namespace;
        }
        if (request.SourceKeys != null)
        {
            _query["sourceKeys"] = request.SourceKeys;
        }
        if (request.DestinationKeys != null)
        {
            _query["destinationKeys"] = request.DestinationKeys;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/mapping",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ProgramsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a mapping program
    /// </summary>
    public async Task<ProgramResponse> GetMappingProgramAsync(string programId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"/mapping/{programId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ProgramResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a mapping program
    /// </summary>
    public async Task<ProgramResponse> UpdateMappingProgramAsync(
        string programId,
        ProgramConfig request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/mapping/{programId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ProgramResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a mapping program
    /// </summary>
    public async Task<Success> DeleteMappingProgramAsync(string programId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/mapping/{programId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Add mapping rules to a program
    /// </summary>
    public async Task<MappingRulesResponse> CreateRulesAsync(
        string programId,
        IEnumerable<MappingRuleConfig> request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/mapping/{programId}/rules",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MappingRulesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes multiple mapping rules from a program
    /// </summary>
    public async Task<Success> DeleteMultipleRulesAsync(
        string programId,
        DeleteMultipleRulesRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/mapping/{programId}/rules",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// List all mapping rules in a program
    /// </summary>
    public async Task<MappingRulesResponse> ListRulesAsync(string programId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/mapping/{programId}/rules"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MappingRulesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a mapping rule from a program
    /// </summary>
    public async Task<MappingRuleResponse> GetRuleAsync(string programId, string mappingId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/mapping/{programId}/rules/{mappingId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MappingRuleResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a mapping rule in a program
    /// </summary>
    public async Task<MappingRuleResponse> UpdateRuleAsync(
        string programId,
        string mappingId,
        MappingRuleConfig request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/mapping/{programId}/rules/{mappingId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MappingRuleResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a list of mapping rules in a program
    /// </summary>
    public async Task<MappingRulesResponse> UpdateRulesAsync(
        string programId,
        IEnumerable<MappingRule> request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/mapping/{programId}/rules",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MappingRulesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a mapping rule from a program
    /// </summary>
    public async Task<Success> DeleteRuleAsync(string programId, string mappingId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/mapping/{programId}/rules/{mappingId}"
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
