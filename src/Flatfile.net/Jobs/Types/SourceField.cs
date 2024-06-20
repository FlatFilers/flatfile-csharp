using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SourceField
{
    /// <summary>
    /// The description of the source field
    /// </summary>
    [JsonPropertyName("sourceField")]
    public object SourceField_ { get; init; }

    /// <summary>
    /// A list of preview values of the data in the source field
    /// </summary>
    [JsonPropertyName("preview")]
    public IEnumerable<string>? Preview { get; init; }
}
