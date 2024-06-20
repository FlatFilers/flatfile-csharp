using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class FieldRecordCounts
{
    [JsonPropertyName("total")]
    public int Total { get; init; }

    [JsonPropertyName("valid")]
    public int Valid { get; init; }

    [JsonPropertyName("error")]
    public int Error { get; init; }

    [JsonPropertyName("empty")]
    public int Empty { get; init; }
}
