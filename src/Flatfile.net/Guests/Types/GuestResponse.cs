using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GuestResponse
{
    [JsonPropertyName("data")]
    public Guest Data { get; init; }
}
