using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListEnvironmentsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Environment> Data { get; init; }

    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}
