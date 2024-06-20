using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class DestinationField
{
    /// <summary>
    /// The description of the destination field
    /// </summary>
    [JsonPropertyName("destinationField")]
    public object DestinationField_ { get; init; }

    /// <summary>
    /// A list of preview values of the data in the destination field
    /// </summary>
    [JsonPropertyName("preview")]
    public IEnumerable<string>? Preview { get; init; }
}
