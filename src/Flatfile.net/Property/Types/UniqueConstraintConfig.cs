using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class UniqueConstraintConfig
{
    /// <summary>
    /// Ignore casing when determining uniqueness
    /// </summary>
    [JsonPropertyName("caseSensitive")]
    public bool? CaseSensitive { get; init; }

    /// <summary>
    /// Do not flag empty values as duplicate
    /// </summary>
    [JsonPropertyName("ignoreEmpty")]
    public bool? IgnoreEmpty { get; init; }
}
