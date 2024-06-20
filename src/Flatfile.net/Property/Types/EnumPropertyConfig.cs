using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EnumPropertyConfig
{
    /// <summary>
    /// Permit the user to create new options for this specific field.
    /// </summary>
    [JsonPropertyName("allowCustom")]
    public bool? AllowCustom { get; init; }

    [JsonPropertyName("options")]
    public IEnumerable<EnumPropertyOption> Options { get; init; }
}
