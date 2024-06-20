using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class VersionResponse
{
    [JsonPropertyName("data")]
    public Version Data { get; init; }
}
