using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Origin
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("slug")]
    public string? Slug { get; init; }
}
