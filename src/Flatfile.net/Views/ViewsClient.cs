using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ViewsClient
{
    private RawClient _client;

    public ViewsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all views for the sheet
    /// </summary>
    public async Task<ListViewsResponse> ListAsync(ListViewsRequest request)
    {
        var _query = new Dictionary<string, object>() { { "sheetId", request.SheetId }, };
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
            return JsonSerializer.Deserialize<ListViewsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Add a new view to the space
    /// </summary>
    public async Task<ViewResponse> CreateAsync(ViewCreate request)
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
            return JsonSerializer.Deserialize<ViewResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single view
    /// </summary>
    public async Task<ViewResponse> GetAsync(string viewId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{viewId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ViewResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a single view
    /// </summary>
    public async Task<ViewResponse> UpdateAsync(string viewId, ViewUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/{viewId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ViewResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a single view
    /// </summary>
    public async Task<Success> DeleteAsync(string viewId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{viewId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
