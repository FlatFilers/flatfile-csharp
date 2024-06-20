using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListWorkbooksResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Workbook> Data { get; init; }
}
