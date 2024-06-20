using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class ListAllEventsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<object> Data { get; init; }
}
