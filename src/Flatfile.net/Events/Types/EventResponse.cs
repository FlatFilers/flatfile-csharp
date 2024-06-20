using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class EventResponse
{
    [JsonPropertyName("data")]
    public object Data { get; init; }
}
