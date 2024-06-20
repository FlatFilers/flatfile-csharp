using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordCountsResponseData
{
    [JsonPropertyName("counts")]
    public RecordCounts Counts { get; init; }

    [JsonPropertyName("success")]
    public bool Success { get; init; }
}
