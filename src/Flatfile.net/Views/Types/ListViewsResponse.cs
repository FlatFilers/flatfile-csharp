using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListViewsResponse
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<View> Data { get; init; }
}
