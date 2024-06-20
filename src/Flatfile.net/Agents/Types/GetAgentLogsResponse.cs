using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetAgentLogsResponse
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<AgentLog>? Data { get; init; }
}
