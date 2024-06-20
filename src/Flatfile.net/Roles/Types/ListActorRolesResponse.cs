using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListActorRolesResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<ActorRoleResponse> Data { get; init; }
}
