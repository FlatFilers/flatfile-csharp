using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SecretsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Secret> Data { get; init; }
}
