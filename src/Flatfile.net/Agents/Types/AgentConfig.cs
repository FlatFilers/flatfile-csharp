using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AgentConfig
{
    /// <summary>
    /// The topics the agent should listen for
    /// </summary>
    [JsonPropertyName("topics")]
    public IEnumerable<EventTopic>? Topics { get; init; }

    /// <summary>
    /// The compiler of the agent
    /// </summary>
    [JsonPropertyName("compiler")]
    public Compiler? Compiler { get; init; }

    /// <summary>
    /// The source of the agent
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; init; }

    /// <summary>
    /// The slug of the agent
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }
}
