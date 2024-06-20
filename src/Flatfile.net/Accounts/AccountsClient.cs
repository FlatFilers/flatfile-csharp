using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AccountsClient
{
    private RawClient _client;

    public AccountsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get the current account
    /// </summary>
    public async Task<AccountResponse> GetCurrentAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/current" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update the current account
    /// </summary>
    public async Task<AccountResponse> UpdateCurrentAsync(AccountPatch request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = "/current",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
