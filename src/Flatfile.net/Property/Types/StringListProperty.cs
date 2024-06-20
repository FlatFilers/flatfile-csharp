using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class StringListProperty
{
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// User friendly field name
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// A short description of the field. Markdown syntax is supported.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("constraints")]
    public IEnumerable<object>? Constraints { get; init; }

    [JsonPropertyName("readonly")]
    public bool? Readonly { get; init; }

    [JsonPropertyName("appearance")]
    public FieldAppearance? Appearance { get; init; }

    /// <summary>
    /// Useful for any contextual metadata regarding the schema. Store any valid json here.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }

    /// <summary>
    /// A unique presentation for a field in the UI.
    /// </summary>
    [JsonPropertyName("treatments")]
    public IEnumerable<string>? Treatments { get; init; }

    [JsonPropertyName("alternativeNames")]
    public IEnumerable<string>? AlternativeNames { get; init; }
}
