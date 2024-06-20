using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class PromptCreate
{
    [JsonPropertyName("prompt")]
    public string Prompt { get; init; }
}
