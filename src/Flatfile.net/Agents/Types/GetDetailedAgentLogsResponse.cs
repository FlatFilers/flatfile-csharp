using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetDetailedAgentLogsResponse
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<DetailedAgentLog> Data { get; init; }
}
