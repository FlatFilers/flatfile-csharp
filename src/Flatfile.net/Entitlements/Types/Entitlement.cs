using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Entitlement
{
    /// <summary>
    /// Short name for the entitlement
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; init; }

    /// <summary>
    /// Contains conditions or limits for an entitlement
    /// </summary>
    [JsonPropertyName("metadata")]
    public object Metadata { get; init; }
}
