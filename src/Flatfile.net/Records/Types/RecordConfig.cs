using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordConfig
{
    [JsonPropertyName("readonly")]
    public bool? Readonly { get; init; }

    [JsonPropertyName("fields")]
    public Dictionary<string, CellConfig>? Fields { get; init; }
}
