using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextWait
{
    [JsonPropertyName("fade")]
    public bool? Fade { get; init; }

    [JsonPropertyName("confetti")]
    public bool? Confetti { get; init; }
}
