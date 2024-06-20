using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextSnapshot
{
    [JsonPropertyName("snapshotId")]
    public string SnapshotId { get; init; }

    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }
}
