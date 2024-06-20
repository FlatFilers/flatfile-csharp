using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CellsResponse
{
    [JsonPropertyName("data")]
    public Dictionary<string, IEnumerable<CellValueWithCounts>> Data { get; init; }
}
