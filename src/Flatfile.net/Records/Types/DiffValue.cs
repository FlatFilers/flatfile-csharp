using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class DiffValue
{
    [JsonPropertyName("snapshotValue")]
    [JsonConverter(
        typeof(OneOfSerializer<OneOf<string, int, long, double, bool, DateOnly, DateTime>>)
    )]
    public OneOf<string, int, long, double, bool, DateOnly, DateTime>? SnapshotValue { get; init; }

    [JsonPropertyName("valid")]
    public bool? Valid { get; init; }

    [JsonPropertyName("messages")]
    public IEnumerable<ValidationMessage>? Messages { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; init; }

    [JsonPropertyName("value")]
    [JsonConverter(
        typeof(OneOfSerializer<OneOf<string, int, long, double, bool, DateOnly, DateTime>>)
    )]
    public OneOf<string, int, long, double, bool, DateOnly, DateTime>? Value { get; init; }

    [JsonPropertyName("layer")]
    public string? Layer { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; init; }
}
