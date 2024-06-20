using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class App
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("namespace")]
    public string Namespace { get; init; }

    [JsonPropertyName("type")]
    public AppType Type { get; init; }

    [JsonPropertyName("entity")]
    public string Entity { get; init; }

    [JsonPropertyName("entityPlural")]
    public string EntityPlural { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("metadata")]
    public object Metadata { get; init; }

    [JsonPropertyName("environmentFilters")]
    public object EnvironmentFilters { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; init; }

    [JsonPropertyName("activatedAt")]
    public DateTime? ActivatedAt { get; init; }
}
