using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class FilesClient
{
    private RawClient _client;

    public FilesClient(RawClient client)
    {
        _client = client;
    }

    public async Task<ListFilesResponse> ListAsync(ListFilesRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize.ToString();
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber.ToString();
        }
        if (request.Mode != null)
        {
            _query["mode"] = request.Mode.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/files",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListFilesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<FileResponse> UploadAsync(CreateFileRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = "/files" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FileResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<FileResponse> GetAsync(string fileId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/files/{fileId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FileResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<Success> DeleteAsync(string fileId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/files/{fileId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update a file, to change the workbook id for example
    /// </summary>
    public async Task<FileResponse> UpdateAsync(string fileId, UpdateFileRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/files/{fileId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FileResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async void DownloadAsync(string fileId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/files/{fileId}/download" }
        );
    }
}
