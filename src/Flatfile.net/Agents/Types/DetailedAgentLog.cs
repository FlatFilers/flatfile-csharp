using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class DetailedAgentLog
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

    /// <summary>
    /// The context of the agent execution
    /// </summary>
    [JsonPropertyName("context")]
    public Dictionary<string, object> Context { get; init; }

    /// <summary>
    /// The log of the agent execution
    /// </summary>
    [JsonPropertyName("log")]
    public string? Log { get; init; }
}
