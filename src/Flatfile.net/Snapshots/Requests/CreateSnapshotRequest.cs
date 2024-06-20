using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class CreateSnapshotRequest
{
    /// <summary>
    /// ID of sheet
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    /// <summary>
    /// Label for the snapshot
    /// </summary>
    [JsonPropertyName("label")]
    public string? Label { get; init; }
}
