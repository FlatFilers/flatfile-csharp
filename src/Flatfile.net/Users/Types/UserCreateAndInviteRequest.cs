using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UserCreateAndInviteRequest
{
    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("actorRoles")]
    public IEnumerable<AssignActorRoleRequest> ActorRoles { get; init; }
}
