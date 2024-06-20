using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class DeleteAllHistoryForUserRequest
{
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }
}
