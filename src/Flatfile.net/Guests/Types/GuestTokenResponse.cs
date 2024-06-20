using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GuestTokenResponse
{
    [JsonPropertyName("data")]
    public GuestToken Data { get; init; }
}
