using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SheetResponse
{
    [JsonPropertyName("data")]
    public Sheet Data { get; init; }
}
