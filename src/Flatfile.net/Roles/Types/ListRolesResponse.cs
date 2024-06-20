using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListRolesResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<RoleResponse> Data { get; init; }
}
