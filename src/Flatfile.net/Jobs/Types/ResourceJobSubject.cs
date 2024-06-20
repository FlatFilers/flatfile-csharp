using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class ResourceJobSubject
{
    [JsonPropertyName("id")]
    public string Id { get; init; }
}
