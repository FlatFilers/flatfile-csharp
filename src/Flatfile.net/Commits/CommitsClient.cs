using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CommitsClient
{
    private RawClient _client;

    public CommitsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the details of a commit version
    /// </summary>
    public async Task<CommitResponse> GetAsync(string commitId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"/commits/{commitId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommitResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Completes a commit version. This marks the commit as complete and acknowledges that the changes have been applied to the sheet.
    /// </summary>
    public async Task<Success> CompleteAsync(string commitId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/commits/{commitId}/complete"
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
    /// Replays a commit:created event.
    /// </summary>
    public async Task<Success> ReplayAsync(string commitId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/commits/{commitId}/replay"
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
