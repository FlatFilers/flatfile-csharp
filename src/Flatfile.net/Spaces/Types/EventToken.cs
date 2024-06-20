using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class EventToken
{
    /// <summary>
    /// The ID of the Account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; init; }

    /// <summary>
    /// The id of the event bus to subscribe to
    /// </summary>
    [JsonPropertyName("subscribeKey")]
    public string? SubscribeKey { get; init; }

    /// <summary>
    /// Time to live in minutes
    /// </summary>
    [JsonPropertyName("ttl")]
    public int? Ttl { get; init; }

    /// <summary>
    /// This should be your API key.
    /// </summary>
    [JsonPropertyName("token")]
    public string? Token { get; init; }
}
