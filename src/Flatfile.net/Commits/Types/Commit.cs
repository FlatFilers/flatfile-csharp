using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Commit
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    /// <summary>
    /// The actor (user or system) who created the commit
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; init; }

    /// <summary>
    /// The actor (user or system) who completed the commit
    /// </summary>
    [JsonPropertyName("completedBy")]
    public string? CompletedBy { get; init; }

    /// <summary>
    /// The time the commit was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// The time the commit was acknowledged
    /// </summary>
    [JsonPropertyName("completedAt")]
    public DateTime? CompletedAt { get; init; }
}
