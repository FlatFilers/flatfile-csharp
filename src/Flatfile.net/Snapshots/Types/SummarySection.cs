using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SummarySection
{
    [JsonPropertyName("total")]
    public int Total { get; init; }

    [JsonPropertyName("byField")]
    public Dictionary<string, int>? ByField { get; init; }
}
