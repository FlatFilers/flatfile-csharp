using System.Text.Json.Serialization;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class CategoryMapping
{
    /// <summary>
    /// The source value to map from
    /// </summary>
    [JsonPropertyName("sourceValue")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, int, bool>>))]
    public OneOf<string, int, bool>? SourceValue { get; init; }

    /// <summary>
    /// The destination value to map to
    /// </summary>
    [JsonPropertyName("destinationValue")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, int, bool>>))]
    public OneOf<string, int, bool>? DestinationValue { get; init; }
}
