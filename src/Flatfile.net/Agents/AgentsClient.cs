using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AgentsClient
{
    private RawClient _client;

    public AgentsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<ListAgentsResponse> ListAsync(ListAgentsRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/agents",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListAgentsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<AgentResponse> CreateAsync(CreateAgentsRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/agents",
                Body = request.Body,
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AgentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<AgentResponse> GetAsync(string agentId, GetAgentRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/agents/{agentId}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AgentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Lists roles assigned to an agent.
    /// </summary>
    public async Task<ListActorRolesResponse> ListAgentRolesAsync(string agentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/agents/{agentId}/roles" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListActorRolesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Assigns a role to a agent.
    /// </summary>
    public async Task<AssignRoleResponse> AssignAgentRoleAsync(
        string agentId,
        AssignActorRoleRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/agents/{agentId}/roles",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AssignRoleResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Removes a role from an agent.
    /// </summary>
    public async Task<Success> DeleteAgentRoleAsync(string agentId, string actorRoleId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/agents/{agentId}/roles/{actorRoleId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<GetAgentLogsResponse> GetAgentLogsAsync(
        string agentId,
        GetAgentLogsRequest request
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
                Path = $"/agents/{agentId}/logs",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GetAgentLogsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<GetDetailedAgentLogResponse> GetAgentLogAsync(
        string eventId,
        GetAgentLogRequest request
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
                Path = $"/agents/log/{eventId}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GetDetailedAgentLogResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<GetDetailedAgentLogsResponse> GetEnvironmentAgentLogsAsync(
        GetEnvironmentAgentLogsRequest request
    )
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        if (request.Success != null)
        {
            _query["success"] = request.Success.ToString();
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize.ToString();
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/agents/logs",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GetDetailedAgentLogsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<GetExecutionsResponse> GetEnvironmentAgentExecutionsAsync(
        GetEnvironmentAgentExecutionsRequest request
    )
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        if (request.Success != null)
        {
            _query["success"] = request.Success.ToString();
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize.ToString();
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/agents/executions",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GetExecutionsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a single agent
    /// </summary>
    public async Task<Success> DeleteAsync(string agentId, DeleteAgentRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "environmentId", request.EnvironmentId },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/agents/{agentId}",
                Query = _query
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
