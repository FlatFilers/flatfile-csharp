using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SheetUpdateRequest
{
    /// <summary>
    /// The name of the Sheet.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The slug of the Sheet.
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    /// <summary>
    /// Useful for any contextual metadata regarding the sheet. Store any valid json
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }
}
