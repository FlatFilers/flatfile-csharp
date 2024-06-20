using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordsResponse
{
    [JsonPropertyName("data")]
    public RecordsResponseData Data { get; init; }
}
