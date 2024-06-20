using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SnapshotSummary
{
    [JsonPropertyName("createdSince")]
    public SummarySection CreatedSince { get; init; }

    [JsonPropertyName("updatedSince")]
    public SummarySection UpdatedSince { get; init; }

    [JsonPropertyName("deletedSince")]
    public SummarySection DeletedSince { get; init; }
}
