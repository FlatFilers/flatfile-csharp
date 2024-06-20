using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class WorkbookResponse
{
    [JsonPropertyName("data")]
    public Workbook Data { get; init; }
}
