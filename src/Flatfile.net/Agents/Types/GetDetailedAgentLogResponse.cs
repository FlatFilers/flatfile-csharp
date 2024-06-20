using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetDetailedAgentLogResponse
{
    [JsonPropertyName("data")]
    public DetailedAgentLog Data { get; init; }
}
