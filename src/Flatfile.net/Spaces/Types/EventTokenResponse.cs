using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EventTokenResponse
{
    [JsonPropertyName("data")]
    public EventToken Data { get; init; }
}
