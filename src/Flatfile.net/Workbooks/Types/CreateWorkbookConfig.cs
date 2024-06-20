using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CreateWorkbookConfig
{
    /// <summary>
    /// The name of the Workbook.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// An optional list of labels for the Workbook.
    /// </summary>
    [JsonPropertyName("labels")]
    public IEnumerable<string>? Labels { get; init; }

    /// <summary>
    /// Space to associate with the Workbook.
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; init; }

    /// <summary>
    /// Environment to associate with the Workbook
    /// </summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// Optional namespace to apply to the Workbook.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Sheets to create on the Workbook.
    /// </summary>
    [JsonPropertyName("sheets")]
    public IEnumerable<SheetConfig>? Sheets { get; init; }

    /// <summary>
    /// Actions to create on the Workbook.
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }

    /// <summary>
    /// The Workbook settings.
    /// </summary>
    [JsonPropertyName("settings")]
    public WorkbookConfigSettings? Settings { get; init; }

    /// <summary>
    /// Metadata for the workbook
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }
}
