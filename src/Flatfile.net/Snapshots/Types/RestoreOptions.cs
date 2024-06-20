using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class RestoreOptions
{
    [JsonPropertyName("created")]
    public bool Created { get; init; }

    [JsonPropertyName("updated")]
    public bool Updated { get; init; }

    [JsonPropertyName("deleted")]
    public bool Deleted { get; init; }
}
