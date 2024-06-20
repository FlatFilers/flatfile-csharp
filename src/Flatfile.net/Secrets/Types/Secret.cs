using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Secret
{
    /// <summary>
    /// The ID of the secret.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// The reference name for a secret.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// The secret value. This is hidden in the UI.
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; init; }

    /// <summary>
    /// The Environment of the secret.
    /// </summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// The Space of the secret.
    /// </summary>
    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; init; }
}
