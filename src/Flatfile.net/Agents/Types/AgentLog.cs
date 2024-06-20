using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class AgentLog
{
    [JsonPropertyName("eventId")]
    public string EventId { get; init; }

    /// <summary>
    /// Whether the agent execution was successful
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; init; }

    [JsonPropertyName("createdAt")]
    public string CreatedAt { get; init; }

    [JsonPropertyName("completedAt")]
    public string CompletedAt { get; init; }

    /// <summary>
    /// The log of the agent execution
    /// </summary>
    [JsonPropertyName("log")]
    public string? Log { get; init; }
}
