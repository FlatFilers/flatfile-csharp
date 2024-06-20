using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Guest
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Date the guest object was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Date the guest object was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    [JsonPropertyName("environmentId")]
    public string EnvironmentId { get; init; }

    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("spaces")]
    public IEnumerable<GuestSpace> Spaces { get; init; }
}
