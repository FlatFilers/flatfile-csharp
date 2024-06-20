using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class MappingRuleConfig
{
    /// <summary>
    /// Name of the mapping rule
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("type")]
    public string Type { get; init; }

    [JsonPropertyName("config")]
    public object? Config { get; init; }

    /// <summary>
    /// Time the mapping rule was last updated
    /// </summary>
    [JsonPropertyName("acceptedAt")]
    public DateTime? AcceptedAt { get; init; }

    /// <summary>
    /// User ID of the contributor of the mapping rule
    /// </summary>
    [JsonPropertyName("acceptedBy")]
    public string? AcceptedBy { get; init; }
}
