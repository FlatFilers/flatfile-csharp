using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EventAttributes
{
    /// <summary>
    /// Date the related entity was last updated
    /// </summary>
    [JsonPropertyName("targetUpdatedAt")]
    public DateTime? TargetUpdatedAt { get; init; }

    /// <summary>
    /// The progress of the event within a collection of iterable events
    /// </summary>
    [JsonPropertyName("progress")]
    public Progress? Progress { get; init; }
}
