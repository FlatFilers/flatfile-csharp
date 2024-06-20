using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SuccessResponse
{
    [JsonPropertyName("success")]
    public bool Success { get; init; }
}
