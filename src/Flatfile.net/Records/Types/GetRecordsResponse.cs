using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetRecordsResponse
{
    [JsonPropertyName("data")]
    public GetRecordsResponseData Data { get; init; }
}
