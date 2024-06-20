using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class ExternalSheetConstraint
{
    [JsonPropertyName("validator")]
    public string Validator { get; init; }

    /// <summary>
    /// The fields that must be unique together
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<string>? Fields { get; init; }

    [JsonPropertyName("config")]
    public object? Config { get; init; }
}
