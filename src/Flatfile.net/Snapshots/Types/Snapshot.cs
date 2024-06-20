using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Snapshot
{
    /// <summary>
    /// The ID of the Snapshot.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// The ID of the Sheet.
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    /// <summary>
    /// The title of the Snapshot.
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// A summary of the Snapshot.
    /// </summary>
    [JsonPropertyName("summary")]
    public SnapshotSummary? Summary { get; init; }

    /// <summary>
    /// The time the Snapshot was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// The actor who created the Snapshot.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; init; }
}
