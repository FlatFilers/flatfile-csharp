using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UserWithRoles
{
    [JsonPropertyName("actorRoles")]
    public IEnumerable<ActorRoleResponse> ActorRoles { get; init; }

    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("idp")]
    public string Idp { get; init; }

    [JsonPropertyName("idpRef")]
    public string? IdpRef { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    [JsonPropertyName("lastSeenAt")]
    public DateTime? LastSeenAt { get; init; }

    [JsonPropertyName("dashboard")]
    public int? Dashboard { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; init; }
}
