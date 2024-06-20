using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SpaceResponse
{
    [JsonPropertyName("data")]
    public Space Data { get; init; }
}
