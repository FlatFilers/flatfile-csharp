using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AppCreate
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("namespace")]
    public string Namespace { get; init; }

    [JsonPropertyName("type")]
    public AppType Type { get; init; }

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
}
