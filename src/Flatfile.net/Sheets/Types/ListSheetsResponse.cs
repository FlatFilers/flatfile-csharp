using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListSheetsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Sheet> Data { get; init; }
}
