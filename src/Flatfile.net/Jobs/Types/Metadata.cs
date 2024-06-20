using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Metadata
{
    [JsonPropertyName("certainty")]
    public Certainty? Certainty { get; init; }

    [JsonPropertyName("confidence")]
    public double? Confidence { get; init; }

    [JsonPropertyName("source")]
    public string? Source { get; init; }
}
