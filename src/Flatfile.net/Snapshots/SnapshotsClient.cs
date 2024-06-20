using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SnapshotsClient
{
    private RawClient _client;

    public SnapshotsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a snapshot of a sheet
    /// </summary>
    public async Task<SnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
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
            return JsonSerializer.Deserialize<SnapshotResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// List all snapshots of a sheet
    /// </summary>
    public async Task<SnapshotsResponse> ListSnapshotsAsync(ListSnapshotRequest request)
    {
        var _query = new Dictionary<string, object>() { { "sheetId", request.SheetId }, };
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
            return JsonSerializer.Deserialize<SnapshotsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets a snapshot of a sheet
    /// </summary>
    public async Task<SnapshotResponse> GetSnapshotAsync(
        string snapshotId,
        GetSnapshotRequest request
    )
    {
        var _query = new Dictionary<string, object>()
        {
            { "includeSummary", request.IncludeSummary.ToString() },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{snapshotId}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SnapshotResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a snapshot of a sheet
    /// </summary>
    public async Task<Success> DeleteSnapshotAsync(string snapshotId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{snapshotId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Restores a snapshot of a sheet
    /// </summary>
    public async Task<SnapshotResponse> RestoreSnapshotAsync(
        string snapshotId,
        RestoreOptions? request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{snapshotId}/restore",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<SnapshotResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets records from a snapshot of a sheet
    /// </summary>
    public async Task<DiffRecordsResponse> GetSnapshotRecordsAsync(
        string snapshotId,
        GetSnapshotRecordsRequest request
    )
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
        if (request.ChangeType != null)
        {
            _query["changeType"] = request.ChangeType;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/{snapshotId}/records",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DiffRecordsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
