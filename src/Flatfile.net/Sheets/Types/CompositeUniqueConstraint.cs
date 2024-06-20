using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CompositeUniqueConstraint
{
    /// <summary>
    /// The name of the constraint
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// The fields that must be unique together
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<string> Fields { get; init; }

    [JsonPropertyName("strategy")]
    public CompositeUniqueConstraintStrategy Strategy { get; init; }
}
