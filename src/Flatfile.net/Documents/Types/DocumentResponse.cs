using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DocumentResponse
{
    [JsonPropertyName("data")]
    public Document Data { get; init; }
}
