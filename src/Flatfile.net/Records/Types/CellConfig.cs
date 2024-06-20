using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class CellConfig
{
    [JsonPropertyName("readonly")]
    public bool? Readonly { get; init; }
}
