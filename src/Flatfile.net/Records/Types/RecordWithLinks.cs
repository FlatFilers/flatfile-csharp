using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordWithLinks
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("values")]
    public Dictionary<string, CellValueWithLinks> Values { get; init; }

    [JsonPropertyName("valid")]
    public bool? Valid { get; init; }

    [JsonPropertyName("messages")]
    public IEnumerable<ValidationMessage>? Messages { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; init; }

    [JsonPropertyName("config")]
    public RecordConfig? Config { get; init; }
}
