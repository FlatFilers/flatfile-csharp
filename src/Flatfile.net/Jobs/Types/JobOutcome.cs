using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcome
{
    [JsonPropertyName("acknowledge")]
    public bool? Acknowledge { get; init; }

    [JsonPropertyName("buttonText")]
    public string? ButtonText { get; init; }

    [JsonPropertyName("next")]
    public object? Next { get; init; }

    [JsonPropertyName("heading")]
    public string? Heading { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }

    [JsonPropertyName("hideDefaultButton")]
    public bool? HideDefaultButton { get; init; }
}
