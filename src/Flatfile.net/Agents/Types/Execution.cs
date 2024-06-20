using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Execution
{
    [JsonPropertyName("eventId")]
    public string EventId { get; init; }

    /// <summary>
    /// Whether the agent execution was successful
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("completedAt")]
    public DateTime CompletedAt { get; init; }

    /// <summary>
    /// The duration of the agent execution
    /// </summary>
    [JsonPropertyName("duration")]
    public int Duration { get; init; }

    /// <summary>
    /// The topics of the agent execution
    /// </summary>
    [JsonPropertyName("topic")]
    public string Topic { get; init; }
}
