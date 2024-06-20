using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GuestsClient
{
    private RawClient _client;

    public GuestsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all guests
    /// </summary>
    public async Task<ListGuestsResponse> ListAsync(ListGuestsRequest request)
    {
        var _query = new Dictionary<string, object>() { { "spaceId", request.SpaceId }, };
        if (request.Email != null)
        {
            _query["email"] = request.Email;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/guests",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListGuestsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Guests are only there to upload, edit, and download files and perform their tasks in a specific Space.
    /// </summary>
    public async Task<CreateGuestResponse> CreateAsync(IEnumerable<GuestConfig> request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/guests",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CreateGuestResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single guest
    /// </summary>
    public async Task<GuestResponse> GetAsync(string guestId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/guests/{guestId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GuestResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a single guest
    /// </summary>
    public async Task<Success> DeleteAsync(string guestId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/guests/{guestId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a single guest, for example to change name or email
    /// </summary>
    public async Task<GuestResponse> UpdateAsync(string guestId, GuestConfigUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/guests/{guestId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GuestResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single guest token
    /// </summary>
    public async Task<GuestTokenResponse> GetGuestTokenAsync(
        string guestId,
        GetGuestTokenRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/guests/{guestId}/token",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<GuestTokenResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Lists roles assigned to a guest.
    /// </summary>
    public async Task<ListActorRolesResponse> ListGuestRolesAsync(string guestId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/guests/{guestId}/roles" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListActorRolesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Assigns a role to a guest.
    /// </summary>
    public async Task<AssignRoleResponse> AssignGuestRoleAsync(
        string guestId,
        AssignActorRoleRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/guests/{guestId}/roles",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AssignRoleResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Removes a role from a guest.
    /// </summary>
    public async Task<Success> DeleteGuestRoleAsync(string guestId, string actorRoleId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/guests/{guestId}/roles/{actorRoleId}"
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
    /// Guests can be created as a named guest on the Space or there’s a global link that will let anonymous guests into the space.
    /// </summary>
    public async Task<Success> InviteAsync(IEnumerable<Invite> request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/invitations",
                Body = request
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
