using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordCounts
{
    [JsonPropertyName("total")]
    public int Total { get; init; }

    [JsonPropertyName("valid")]
    public int Valid { get; init; }

    [JsonPropertyName("error")]
    public int Error { get; init; }

    [JsonPropertyName("errorsByField")]
    public Dictionary<string, int>? ErrorsByField { get; init; }

    /// <summary>
    /// Counts for valid, error, and total records grouped by field key
    /// </summary>
    [JsonPropertyName("byField")]
    public Dictionary<string, FieldRecordCounts>? ByField { get; init; }
}
