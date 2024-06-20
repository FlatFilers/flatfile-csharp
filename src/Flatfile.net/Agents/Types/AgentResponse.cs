using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AgentResponse
{
    [JsonPropertyName("data")]
    public Agent? Data { get; init; }
}
