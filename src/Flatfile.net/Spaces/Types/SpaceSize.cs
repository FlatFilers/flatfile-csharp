using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SpaceSize
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("numUsers")]
    public int NumUsers { get; init; }

    [JsonPropertyName("pdv")]
    public int Pdv { get; init; }

    [JsonPropertyName("numFiles")]
    public int NumFiles { get; init; }
}
