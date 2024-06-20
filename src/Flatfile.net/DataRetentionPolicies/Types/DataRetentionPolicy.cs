using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DataRetentionPolicy
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Date the policy was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Date the policy was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    [JsonPropertyName("type")]
    public DataRetentionPolicyEnum Type { get; init; }

    [JsonPropertyName("period")]
    public int Period { get; init; }

    [JsonPropertyName("environmentId")]
    public string EnvironmentId { get; init; }
}
