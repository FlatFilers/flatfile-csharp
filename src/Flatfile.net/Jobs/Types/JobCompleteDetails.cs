using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobCompleteDetails
{
    [JsonPropertyName("outcome")]
    public JobOutcome? Outcome { get; init; }

    [JsonPropertyName("info")]
    public string? Info { get; init; }
}
