using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DocumentsClient
{
    private RawClient _client;

    public DocumentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all documents for a space
    /// </summary>
    public async Task<ListDocumentsResponse> ListAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListDocumentsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Add a new document to the space
    /// </summary>
    public async Task<DocumentResponse> CreateAsync(DocumentConfig request)
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
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single document
    /// </summary>
    public async Task<DocumentResponse> GetAsync(string documentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{documentId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// updates a single document, for only the body and title
    /// </summary>
    public async Task<DocumentResponse> UpdateAsync(string documentId, DocumentConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/{documentId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DocumentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a single document
    /// </summary>
    public async Task<Success> DeleteAsync(string documentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{documentId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
