using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextRetry
{
    [JsonPropertyName("label")]
    public string? Label { get; init; }
}
