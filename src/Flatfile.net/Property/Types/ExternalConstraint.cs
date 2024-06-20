using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class ExternalConstraint
{
    [JsonPropertyName("validator")]
    public string Validator { get; init; }

    [JsonPropertyName("config")]
    public object? Config { get; init; }
}
