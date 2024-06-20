using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Error
{
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    [JsonPropertyName("message")]
    public string Message { get; init; }
}
