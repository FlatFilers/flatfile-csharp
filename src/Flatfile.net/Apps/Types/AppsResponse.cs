using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AppsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<App> Data { get; init; }
}
