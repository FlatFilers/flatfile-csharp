using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobCancelDetails
{
    [JsonPropertyName("info")]
    public string? Info { get; init; }
}
