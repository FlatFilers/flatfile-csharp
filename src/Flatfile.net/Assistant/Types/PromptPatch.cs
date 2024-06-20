using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class PromptPatch
{
    [JsonPropertyName("prompt")]
    public string? Prompt { get; init; }
}
