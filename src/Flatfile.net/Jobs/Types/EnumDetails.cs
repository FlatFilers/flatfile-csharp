using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class EnumDetails
{
    /// <summary>
    /// The mapping of source values to destination values
    /// </summary>
    [JsonPropertyName("mapping")]
    public IEnumerable<CategoryMapping> Mapping { get; init; }

    /// <summary>
    /// A list of source values that are not mapped from
    /// </summary>
    [JsonPropertyName("unusedSourceValues")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, int, bool>,
            OneOfSerializer<OneOf<string, int, bool>>
        >)
    )]
    public IEnumerable<OneOf<string, int, bool>>? UnusedSourceValues { get; init; }

    /// <summary>
    /// A list of destination values that are not mapped to
    /// </summary>
    [JsonPropertyName("unusedDestinationValues")]
    [JsonConverter(
        typeof(CollectionItemSerializer<
            OneOf<string, int, bool>,
            OneOfSerializer<OneOf<string, int, bool>>
        >)
    )]
    public IEnumerable<OneOf<string, int, bool>>? UnusedDestinationValues { get; init; }
}
