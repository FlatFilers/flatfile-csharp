using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class PromptResponse
{
    [JsonPropertyName("data")]
    public Prompt Data { get; init; }
}
