using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Progress
{
    /// <summary>
    /// The current progress of the event
    /// </summary>
    [JsonPropertyName("current")]
    public int? Current { get; init; }

    /// <summary>
    /// The total number of events in this group
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }

    /// <summary>
    /// The percent complete of the event group
    /// </summary>
    [JsonPropertyName("percent")]
    public int? Percent { get; init; }
}
