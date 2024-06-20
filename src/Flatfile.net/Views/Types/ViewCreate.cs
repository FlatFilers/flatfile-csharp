using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ViewCreate
{
    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("config")]
    public ViewConfig Config { get; init; }
}
