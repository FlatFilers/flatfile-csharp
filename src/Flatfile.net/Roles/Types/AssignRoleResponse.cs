using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AssignRoleResponse
{
    [JsonPropertyName("data")]
    public AssignRoleResponseData Data { get; init; }
}
