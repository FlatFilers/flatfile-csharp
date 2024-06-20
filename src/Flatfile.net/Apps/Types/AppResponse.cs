using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AppResponse
{
    [JsonPropertyName("data")]
    public App Data { get; init; }
}
