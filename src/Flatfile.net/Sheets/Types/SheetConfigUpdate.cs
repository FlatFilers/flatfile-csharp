using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SheetConfigUpdate
{
    /// <summary>
    /// The name of your Sheet as it will appear to your end users.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// A sentence or two describing the purpose of your Sheet.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A unique identifier for your Sheet. **Required when updating a Workbook.**
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    /// <summary>
    /// A boolean specifying whether or not this sheet is read only. Read only sheets are not editable by end users.
    /// </summary>
    [JsonPropertyName("readonly")]
    public bool? Readonly { get; init; }

    /// <summary>
    /// Allow end users to add fields during mapping.
    /// </summary>
    [JsonPropertyName("allowAdditionalFields")]
    public bool? AllowAdditionalFields { get; init; }

    /// <summary>
    /// The minimum confidence required to automatically map a field
    /// </summary>
    [JsonPropertyName("mappingConfidenceThreshold")]
    public double? MappingConfidenceThreshold { get; init; }

    /// <summary>
    /// Control Sheet-level access for all users.
    /// </summary>
    [JsonPropertyName("access")]
    public IEnumerable<SheetAccess>? Access { get; init; }

    /// <summary>
    /// Where you define your Sheet’s data schema.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<object>? Fields { get; init; }

    /// <summary>
    /// An array of actions that end users can perform on this Sheet.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }
}
