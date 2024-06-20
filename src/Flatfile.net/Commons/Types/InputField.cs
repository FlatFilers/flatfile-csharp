using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class InputField
{
    /// <summary>
    /// Unique key for a Field.
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// Visible name of a Field.
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; init; }

    /// <summary>
    /// Brief description below the name of the Field.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Field Types inform the user interface how to sort and display data.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; }

    /// <summary>
    /// Default value for a Field.
    /// </summary>
    [JsonPropertyName("defaultValue")]
    public object? DefaultValue { get; init; }

    /// <summary>
    /// Additional configuration for enum Fields.
    /// </summary>
    [JsonPropertyName("config")]
    public InputConfig? Config { get; init; }

    /// <summary>
    /// Indicate additional validations that will be applied to the Field.
    /// </summary>
    [JsonPropertyName("constraints")]
    public IEnumerable<InputConstraint>? Constraints { get; init; }
}
