using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ViewResponse
{
    [JsonPropertyName("data")]
    public View Data { get; init; }
}
