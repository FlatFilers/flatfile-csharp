using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SheetsClient
{
    private RawClient _client;

    public SheetsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns sheets in a workbook
    /// </summary>
    public async Task<ListSheetsResponse> ListAsync(ListSheetsRequest request)
    {
        var _query = new Dictionary<string, object>() { { "workbookId", request.WorkbookId }, };
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
            return JsonSerializer.Deserialize<ListSheetsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a sheet in a workbook
    /// </summary>
    public async Task<SheetResponse> GetAsync(string sheetId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{sheetId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SheetResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a specific sheet from a workbook
    /// </summary>
    public async Task<Success> DeleteAsync(string sheetId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{sheetId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Trigger data hooks and validation to run on a sheet
    /// </summary>
    public async Task<Success> ValidateAsync(string sheetId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/{sheetId}/validate" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns records from a sheet in a workbook as a csv file
    /// </summary>
    public async void GetRecordsAsCsvAsync(string sheetId, GetRecordsCsvRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.VersionId != null)
        {
            _query["versionId"] = request.VersionId;
        }
        if (request.CommitId != null)
        {
            _query["commitId"] = request.CommitId;
        }
        if (request.SinceVersionId != null)
        {
            _query["sinceVersionId"] = request.SinceVersionId;
        }
        if (request.SinceCommitId != null)
        {
            _query["sinceCommitId"] = request.SinceCommitId;
        }
        if (request.SortField != null)
        {
            _query["sortField"] = request.SortField;
        }
        if (request.SortDirection != null)
        {
            _query["sortDirection"] = request.SortDirection;
        }
        if (request.Filter != null)
        {
            _query["filter"] = request.Filter;
        }
        if (request.FilterField != null)
        {
            _query["filterField"] = request.FilterField;
        }
        if (request.SearchValue != null)
        {
            _query["searchValue"] = request.SearchValue;
        }
        if (request.SearchField != null)
        {
            _query["searchField"] = request.SearchField;
        }
        if (request.Ids != null)
        {
            _query["ids"] = request.Ids;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{sheetId}/download",
                Query = _query
            }
        );
    }

    /// <summary>
    /// Returns counts of records from a sheet
    /// </summary>
    public async Task<RecordCountsResponse> GetRecordCountsAsync(
        string sheetId,
        GetRecordCountsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.VersionId != null)
        {
            _query["versionId"] = request.VersionId;
        }
        if (request.SinceVersionId != null)
        {
            _query["sinceVersionId"] = request.SinceVersionId;
        }
        if (request.CommitId != null)
        {
            _query["commitId"] = request.CommitId;
        }
        if (request.SinceCommitId != null)
        {
            _query["sinceCommitId"] = request.SinceCommitId;
        }
        if (request.Filter != null)
        {
            _query["filter"] = request.Filter;
        }
        if (request.FilterField != null)
        {
            _query["filterField"] = request.FilterField;
        }
        if (request.SearchValue != null)
        {
            _query["searchValue"] = request.SearchValue;
        }
        if (request.SearchField != null)
        {
            _query["searchField"] = request.SearchField;
        }
        if (request.ByField != null)
        {
            _query["byField"] = request.ByField;
        }
        if (request.Q != null)
        {
            _query["q"] = request.Q;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{sheetId}/counts",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RecordCountsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns the commit versions for a sheet
    /// </summary>
    public async Task<ListCommitsResponse> GetSheetCommitsAsync(
        string sheetId,
        ListSheetCommitsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Completed != null)
        {
            _query["completed"] = request.Completed;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{sheetId}/commits",
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

    /// <summary>
    /// Locks a sheet
    /// </summary>
    public async Task<Success> LockSheetAsync(string sheetId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/{sheetId}/lock" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Removes a lock from a sheet
    /// </summary>
    public async Task<Success> UnlockSheetAsync(string sheetId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/{sheetId}/unlock" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns record cell values grouped by all fields in the sheet
    /// </summary>
    public async Task<CellsResponse> GetCellValuesAsync(
        string sheetId,
        GetFieldValuesRequest request
    )
    {
        var _query = new Dictionary<string, object>()
        {
            { "distinct", request.Distinct.ToString() },
        };
        if (request.FieldKey != null)
        {
            _query["fieldKey"] = request.FieldKey;
        }
        if (request.SortField != null)
        {
            _query["sortField"] = request.SortField;
        }
        if (request.SortDirection != null)
        {
            _query["sortDirection"] = request.SortDirection;
        }
        if (request.Filter != null)
        {
            _query["filter"] = request.Filter;
        }
        if (request.FilterField != null)
        {
            _query["filterField"] = request.FilterField;
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize;
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber;
        }
        if (request.IncludeCounts != null)
        {
            _query["includeCounts"] = request.IncludeCounts;
        }
        if (request.SearchValue != null)
        {
            _query["searchValue"] = request.SearchValue;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{sheetId}/cells",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CellsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates Sheet
    /// </summary>
    public async Task<SheetResponse> UpdateSheetAsync(string sheetId, SheetUpdateRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/{sheetId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SheetResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
