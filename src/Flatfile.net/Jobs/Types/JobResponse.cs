using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobResponse
{
    [JsonPropertyName("data")]
    public Job Data { get; init; }
}
