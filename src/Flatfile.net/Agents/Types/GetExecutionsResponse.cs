using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetExecutionsResponse
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<Execution> Data { get; init; }
}
