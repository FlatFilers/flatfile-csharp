using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Workbook
{
    /// <summary>
    /// ID of the Workbook.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Name of the Workbook.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Associated Space ID of the Workbook.
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string SpaceId { get; init; }

    /// <summary>
    /// Associated Environment ID of the Workbook.
    /// </summary>
    [JsonPropertyName("environmentId")]
    public string EnvironmentId { get; init; }

    /// <summary>
    /// A list of Sheets associated with the Workbook.
    /// </summary>
    [JsonPropertyName("sheets")]
    public IEnumerable<Sheet>? Sheets { get; init; }

    /// <summary>
    /// A list of labels for the Workbook.
    /// </summary>
    [JsonPropertyName("labels")]
    public IEnumerable<string>? Labels { get; init; }

    /// <summary>
    /// A list of Actions associated with the Workbook.
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

    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Date the workbook was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    /// <summary>
    /// Date the workbook was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Date the workbook was created
    /// </summary>
    [JsonPropertyName("expiredAt")]
    public DateTime? ExpiredAt { get; init; }
}
