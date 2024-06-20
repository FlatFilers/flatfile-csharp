using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListFilesResponse
{
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }

    [JsonPropertyName("data")]
    public IEnumerable<File> Data { get; init; }
}
