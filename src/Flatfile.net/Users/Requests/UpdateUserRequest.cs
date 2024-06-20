using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class UpdateUserRequest
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("dashboard")]
    public int? Dashboard { get; init; }
}
