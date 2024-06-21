using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SpacesClient
{
    private RawClient _client;

    public SpacesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all spaces for an account or environment
    /// </summary>
    public async Task<ListSpacesResponse> ListAsync(ListSpacesRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.EnvironmentId != null)
        {
            _query["environmentId"] = request.EnvironmentId;
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize.ToString();
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber.ToString();
        }
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.Namespace != null)
        {
            _query["namespace"] = request.Namespace;
        }
        if (request.Archived != null)
        {
            _query["archived"] = request.Archived.ToString();
        }
        if (request.SortField != null)
        {
            _query["sortField"] = request.SortField.ToString();
        }
        if (request.SortDirection != null)
        {
            _query["sortDirection"] = request.SortDirection.ToString();
        }
        if (request.IsCollaborative != null)
        {
            _query["isCollaborative"] = request.IsCollaborative.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/spaces",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListSpacesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a new space based on an existing Space Config
    /// </summary>
    public async Task<SpaceResponse> CreateAsync(SpaceConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/spaces",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SpaceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single space
    /// </summary>
    public async Task<SpaceResponse> GetAsync(string spaceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/spaces/{spaceId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SpaceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete a space
    /// </summary>
    public async Task<Success> DeleteAsync(string spaceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/spaces/{spaceId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Delete multiple spaces by id
    /// </summary>
    public async Task<Success> BulkDeleteAsync(DeleteSpacesRequest request)
    {
        var _query = new Dictionary<string, object>() { { "spaceIds", request.SpaceIds }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = "/spaces",
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

    /// <summary>
    /// Update a space, to change the name for example
    /// </summary>
    public async Task<SpaceResponse> UpdateAsync(string spaceId, SpaceConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/spaces/{spaceId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SpaceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Sets archivedAt timestamp on a space
    /// </summary>
    public async Task<Success> ArchiveSpaceAsync(string spaceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/spaces/{spaceId}/archive"
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
