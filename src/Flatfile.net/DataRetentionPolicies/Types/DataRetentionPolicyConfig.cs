using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DataRetentionPolicyConfig
{
    [JsonPropertyName("type")]
    public DataRetentionPolicyEnum Type { get; init; }

    [JsonPropertyName("period")]
    public int Period { get; init; }

    [JsonPropertyName("environmentId")]
    public string EnvironmentId { get; init; }
}
