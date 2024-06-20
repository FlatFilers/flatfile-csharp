using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class ArrayableProperty
{
    /// <summary>
    /// Will allow multiple values and store as an array
    /// </summary>
    [JsonPropertyName("isArray")]
    public bool? IsArray { get; init; }
}
