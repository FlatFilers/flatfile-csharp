using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ReferencePropertyConfig
{
    /// <summary>
    /// Full path reference to a sheet configuration. Must be in the same workbook.
    /// </summary>
    [JsonPropertyName("ref")]
    public string Ref { get; init; }

    /// <summary>
    /// Key of the property to use as the reference key. Defaults to `id`
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// The type of relationship this defines
    /// </summary>
    [JsonPropertyName("relationship")]
    public ReferencePropertyRelationship Relationship { get; init; }
}
