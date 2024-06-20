using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Prompt
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// ID of the user/guest who created the prompt
    /// </summary>
    [JsonPropertyName("createdById")]
    public string CreatedById { get; init; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; init; }

    /// <summary>
    /// Text for prompts for AI Assist
    /// </summary>
    [JsonPropertyName("prompt")]
    public string Prompt_ { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; init; }
}
