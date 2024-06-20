using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class WorkbookUpdate
{
    /// <summary>
    /// The name of the Workbook.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// An optional list of labels for the Workbook.
    /// </summary>
    [JsonPropertyName("labels")]
    public IEnumerable<string>? Labels { get; init; }

    /// <summary>
    /// The Space Id associated with the Workbook.
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; init; }

    /// <summary>
    /// The Environment Id associated with the Workbook.
    /// </summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// The namespace of the Workbook.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Describes shape of data as well as behavior
    /// </summary>
    [JsonPropertyName("sheets")]
    public IEnumerable<SheetConfigOrUpdate>? Sheets { get; init; }

    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }

    /// <summary>
    /// Metadata for the workbook
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }
}
