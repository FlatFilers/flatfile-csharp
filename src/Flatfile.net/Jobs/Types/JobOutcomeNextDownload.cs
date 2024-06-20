using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextDownload
{
    [JsonPropertyName("url")]
    public string Url { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }

    [JsonPropertyName("fileName")]
    public string? FileName { get; init; }
}
