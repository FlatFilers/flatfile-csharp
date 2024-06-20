using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UserWithRolesResponse
{
    [JsonPropertyName("data")]
    public UserWithRoles Data { get; init; }
}
