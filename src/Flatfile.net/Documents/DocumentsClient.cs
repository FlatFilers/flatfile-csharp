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
    public async Task<ListDocumentsResponse> ListAsync(string spaceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/spaces/{spaceId}/documents"
            }
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
    public async Task<DocumentResponse> CreateAsync(string spaceId, DocumentConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/spaces/{spaceId}/documents",
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
    public async Task<DocumentResponse> GetAsync(string spaceId, string documentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/spaces/{spaceId}/documents/{documentId}"
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
    /// updates a single document, for only the body and title
    /// </summary>
    public async Task<DocumentResponse> UpdateAsync(
        string spaceId,
        string documentId,
        DocumentConfig request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/spaces/{spaceId}/documents/{documentId}",
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
    public async Task<Success> DeleteAsync(string spaceId, string documentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/spaces/{spaceId}/documents/{documentId}"
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
