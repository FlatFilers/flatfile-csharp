using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SuccessData
{
    [JsonPropertyName("success")]
    public bool Success { get; init; }
}
