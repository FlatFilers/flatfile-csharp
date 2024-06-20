using System.Text.Json.Serialization;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class AssignActorRoleRequest
{
    [JsonPropertyName("roleId")]
    public string RoleId { get; init; }

    [JsonPropertyName("resourceId")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, string, string>>))]
    public OneOf<string, string, string> ResourceId { get; init; }
}
