using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class BooleanPropertyConfig
{
    /// <summary>
    /// Allow a neither true or false state to be stored as `null`
    /// </summary>
    [JsonPropertyName("allowIndeterminate")]
    public bool AllowIndeterminate { get; init; }
}
