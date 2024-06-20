using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class EnumPropertyOption
{
    /// <summary>
    /// A visual label for this option, defaults to value if not provided
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// A short description for this option
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// An optional color to assign this option
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; init; }

    /// <summary>
    /// A reference pointer to a previously registered icon
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    /// <summary>
    /// An arbitrary JSON object to be associated with this option and made available to hooks
    /// </summary>
    [JsonPropertyName("meta")]
    public Dictionary<string, object>? Meta { get; init; }

    /// <summary>
    /// The value or ID of this option. This value will be sent in egress. The type is a string | integer | boolean.
    /// </summary>
    [JsonPropertyName("value")]
    public object Value { get; init; }

    /// <summary>
    /// Alternative names to match this enum option to
    /// </summary>
    [JsonPropertyName("alternativeNames")]
    public IEnumerable<string>? AlternativeNames { get; init; }
}
