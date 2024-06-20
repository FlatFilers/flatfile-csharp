using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EnvironmentResponse
{
    [JsonPropertyName("data")]
    public Environment Data { get; init; }
}
