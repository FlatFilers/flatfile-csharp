using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListAgentsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Agent>? Data { get; init; }
}
