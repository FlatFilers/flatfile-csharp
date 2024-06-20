using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextUrl
{
    [JsonPropertyName("url")]
    public string Url { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }
}
