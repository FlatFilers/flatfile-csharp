using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class NumberConfig
{
    /// <summary>
    /// Number of decimal places to round data to
    /// </summary>
    [JsonPropertyName("decimalPlaces")]
    public int? DecimalPlaces { get; init; }
}
