using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordCountsResponse
{
    [JsonPropertyName("data")]
    public RecordCountsResponseData Data { get; init; }
}
