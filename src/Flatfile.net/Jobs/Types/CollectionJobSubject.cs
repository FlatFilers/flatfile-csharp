using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class CollectionJobSubject
{
    [JsonPropertyName("resource")]
    public string Resource { get; init; }

    [JsonPropertyName("params")]
    public Dictionary<string, object>? Params { get; init; }

    [JsonPropertyName("query")]
    public Dictionary<string, object>? Query { get; init; }
}
