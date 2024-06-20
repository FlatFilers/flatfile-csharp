using System.Text.Json.Serialization;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class AssignRoleResponseData
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("roleId")]
    public string RoleId { get; init; }

    [JsonPropertyName("actorId")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, string, string>>))]
    public OneOf<string, string, string> ActorId { get; init; }

    [JsonPropertyName("resourceId")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, string, string>>))]
    public OneOf<string, string, string> ResourceId { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }
}
