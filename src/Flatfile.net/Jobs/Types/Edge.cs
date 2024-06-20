using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Edge
{
    /// <summary>
    /// The description of the source field
    /// </summary>
    [JsonPropertyName("sourceField")]
    public object SourceField { get; init; }

    /// <summary>
    /// The description of the destination field
    /// </summary>
    [JsonPropertyName("destinationField")]
    public object DestinationField { get; init; }

    /// <summary>
    /// A list of preview values of the data in the destination field
    /// </summary>
    [JsonPropertyName("preview")]
    public IEnumerable<string>? Preview { get; init; }

    /// <summary>
    /// Only available if one or more of the destination fields is of type enum. Provides category mapping.
    /// </summary>
    [JsonPropertyName("enumDetails")]
    public EnumDetails? EnumDetails { get; init; }

    /// <summary>
    /// Metadata about the edge
    /// </summary>
    [JsonPropertyName("metadata")]
    public Metadata? Metadata { get; init; }
}
