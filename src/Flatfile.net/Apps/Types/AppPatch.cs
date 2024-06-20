using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class AppPatch
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    [JsonPropertyName("entity")]
    public string? Entity { get; init; }

    [JsonPropertyName("entityPlural")]
    public string? EntityPlural { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }

    [JsonPropertyName("environmentFilters")]
    public object? EnvironmentFilters { get; init; }

    [JsonPropertyName("activatedAt")]
    public DateTime? ActivatedAt { get; init; }
}
