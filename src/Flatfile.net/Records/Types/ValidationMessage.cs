using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ValidationMessage
{
    [JsonPropertyName("field")]
    public string? Field { get; init; }

    [JsonPropertyName("type")]
    public ValidationType? Type { get; init; }

    [JsonPropertyName("source")]
    public ValidationSource? Source { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// This JSONPath is based on the root of mapped cell object.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; init; }
}
