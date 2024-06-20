using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class MappingRuleOrConfig
{
    /// <summary>
    /// ID of the mapping rule
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Confidence of the mapping rule
    /// </summary>
    [JsonPropertyName("confidence")]
    public int? Confidence { get; init; }

    /// <summary>
    /// User ID of the creator of the mapping rule
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; init; }

    /// <summary>
    /// Time the mapping rule was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// Time the mapping rule was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; init; }

    /// <summary>
    /// Time the mapping rule was deleted
    /// </summary>
    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; init; }

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
