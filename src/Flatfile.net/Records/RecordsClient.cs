using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordsClient
{
    private RawClient _client;

    public RecordsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns records from a sheet in a workbook
    /// </summary>
    public async Task<GetRecordsResponse> GetAsync(GetRecordsRequest request)
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
        if (request.IncludeLength != null)
        {
            _query["includeLength"] = request.IncludeLength;
        }
        if (request.IncludeLinks != null)
        {
            _query["includeLinks"] = request.IncludeLinks;
        }
        if (request.IncludeMessages != null)
        {
            _query["includeMessages"] = request.IncludeMessages;
        }
        if (request.For != null)
        {
            _query["for"] = request.For;
        }
        if (request.Q != null)
        {
            _query["q"] = request.Q;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/records",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GetRecordsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates existing records in a workbook sheet
    /// </summary>
    public async Task<VersionResponse> UpdateAsync(IEnumerable<Record> request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = "/records",
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

    /// <summary>
    /// Adds records to a workbook sheet
    /// </summary>
    public async Task<RecordsResponse> InsertAsync(
        IEnumerable<Dictionary<string, CellValue>> request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/records",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RecordsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes records from a workbook sheet
    /// </summary>
    public async Task<Success> DeleteAsync(DeleteRecordsRequest request)
    {
        var _query = new Dictionary<string, object>() { { "ids", request.Ids }, };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = "/records",
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
    /// Searches for all values that match the 'find' value (globally or for a specific field via 'fieldKey') and replaces them with the 'replace' value. Wrap 'find' value in double quotes for exact match (""). Returns a commitId for the updated records
    /// </summary>
    public async Task<VersionResponse> FindAndReplaceAsync(FindAndReplaceRecordRequest request)
    {
        var _query = new Dictionary<string, object>() { };
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
        if (request.Q != null)
        {
            _query["q"] = request.Q;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = "/find-replace",
                Query = _query
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
