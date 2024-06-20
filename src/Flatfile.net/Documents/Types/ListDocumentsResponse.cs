using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListDocumentsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Document> Data { get; init; }
}
