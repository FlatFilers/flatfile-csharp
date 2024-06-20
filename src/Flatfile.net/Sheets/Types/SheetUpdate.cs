using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SheetUpdate
{
    /// <summary>
    /// The ID of the Sheet.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The ID of the Workbook.
    /// </summary>
    [JsonPropertyName("workbookId")]
    public string? WorkbookId { get; init; }

    /// <summary>
    /// Describes shape of data as well as behavior.
    /// </summary>
    [JsonPropertyName("config")]
    public SheetConfig? Config { get; init; }

    /// <summary>
    /// Useful for any contextual metadata regarding the sheet. Store any valid json
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }

    /// <summary>
    /// The scoped namespace of the Sheet.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Date the sheet was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; init; }

    /// <summary>
    /// Date the sheet was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; init; }
}
