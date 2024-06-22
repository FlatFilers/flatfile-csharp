using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class WorkbooksClient
{
    private RawClient _client;

    public WorkbooksClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all workbooks matching a filter for an account or space
    /// </summary>
    public async Task<ListWorkbooksResponse> ListAsync(ListWorkbooksRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        if (request.IncludeCounts != null)
        {
            _query["includeCounts"] = request.IncludeCounts.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/workbooks",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListWorkbooksResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a workbook and adds it to a space
    /// </summary>
    public async Task<WorkbookResponse> CreateAsync(CreateWorkbookConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/workbooks",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<WorkbookResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single workbook
    /// </summary>
    public async Task<WorkbookResponse> GetAsync(string workbookId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/workbooks/{workbookId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<WorkbookResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a workbook and all of its record data permanently
    /// </summary>
    public async Task<Success> DeleteAsync(string workbookId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/workbooks/{workbookId}"
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
    /// Updates a workbook
    /// </summary>
    public async Task<WorkbookResponse> UpdateAsync(string workbookId, WorkbookUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/workbooks/{workbookId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<WorkbookResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns the commits for a workbook
    /// </summary>
    public async Task<ListCommitsResponse> GetWorkbookCommitsAsync(
        string workbookId,
        ListWorkbookCommitsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Completed != null)
        {
            _query["completed"] = request.Completed.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/workbooks/{workbookId}/commits",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListCommitsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
