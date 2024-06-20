using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CreateEventConfig
{
    [JsonPropertyName("topic")]
    public EventTopic Topic { get; init; }

    [JsonPropertyName("payload")]
    public Dictionary<string, object> Payload { get; init; }

    /// <summary>
    /// Date the event was deleted
    /// </summary>
    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; init; }

    /// <summary>
    /// The domain of the event
    /// </summary>
    [JsonPropertyName("domain")]
    public Domain Domain { get; init; }

    /// <summary>
    /// The context of the event
    /// </summary>
    [JsonPropertyName("context")]
    public Context Context { get; init; }

    /// <summary>
    /// The attributes of the event
    /// </summary>
    [JsonPropertyName("attributes")]
    public EventAttributes? Attributes { get; init; }

    /// <summary>
    /// The callback url to acknowledge the event
    /// </summary>
    [JsonPropertyName("callbackUrl")]
    public string? CallbackUrl { get; init; }

    /// <summary>
    /// The url to retrieve the data associated with the event
    /// </summary>
    [JsonPropertyName("dataUrl")]
    public string? DataUrl { get; init; }

    [JsonPropertyName("target")]
    public string? Target { get; init; }

    [JsonPropertyName("origin")]
    public Origin? Origin { get; init; }

    [JsonPropertyName("namespaces")]
    public IEnumerable<string>? Namespaces { get; init; }
}
