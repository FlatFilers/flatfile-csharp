using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UsersClient
{
    private RawClient _client;

    public UsersClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets a list of users
    /// </summary>
    public async Task<ListUsersResponse> ListAsync(ListUsersRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Email != null)
        {
            _query["email"] = request.Email;
        }
        if (request.Search != null)
        {
            _query["search"] = request.Search;
        }
        if (request.SortField != null)
        {
            _query["sortField"] = request.SortField.ToString();
        }
        if (request.SortDirection != null)
        {
            _query["sortDirection"] = request.SortDirection.ToString();
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize.ToString();
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "users",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListUsersResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates and invites a new user to your account.
    /// </summary>
    public async Task<UserWithRolesResponse> CreateAndInviteAsync(
        UserCreateAndInviteRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "users/invite",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<UserWithRolesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Resends an invite to a user for your account.
    /// </summary>
    public async Task<Success> ResendInviteAsync(string userId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"users/{userId}/resend-invite"
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
    /// Updates a user
    /// </summary>
    public async Task<UserResponse> UpdateAsync(string userId, UpdateUserRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"users/{userId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<UserResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets a user
    /// </summary>
    public async Task<UserResponse> GetAsync(string userId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"users/{userId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<UserResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes a user
    /// </summary>
    public async Task<Success> DeleteAsync(string userId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Delete, Path = $"users/{userId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Lists roles assigned to a user.
    /// </summary>
    public async Task<ListActorRolesResponse> ListUserRolesAsync(string userId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"users/{userId}/roles" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListActorRolesResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Assigns a role to a user.
    /// </summary>
    public async Task<AssignRoleResponse> AssignUserRoleAsync(
        string userId,
        AssignActorRoleRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"users/{userId}/roles",
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
    /// Removes a role from a user.
    /// </summary>
    public async Task<Success> DeleteUserRoleAsync(string userId, string actorRoleId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"users/{userId}/roles/{actorRoleId}"
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
