using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Invite
{
    [JsonPropertyName("guestId")]
    public string GuestId { get; init; }

    [JsonPropertyName("spaceId")]
    public string SpaceId { get; init; }

    /// <summary>
    /// The name of the person or company sending the invitation
    /// </summary>
    [JsonPropertyName("fromName")]
    public string? FromName { get; init; }

    /// <summary>
    /// Message to send with the invite
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
