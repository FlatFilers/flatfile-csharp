using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class RecordBase
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Deprecated, use `commitId` instead.
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; init; }

    [JsonPropertyName("commitId")]
    public string? CommitId { get; init; }

    /// <summary>
    /// Auto-generated value based on whether the record contains a field with an error message. Cannot be set via the API.
    /// </summary>
    [JsonPropertyName("valid")]
    public bool? Valid { get; init; }

    /// <summary>
    /// This record level `messages` property is deprecated and no longer stored or used. Use the `messages` property on the individual cell values instead. This property will be removed in a future release.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<ValidationMessage>? Messages { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; init; }

    [JsonPropertyName("config")]
    public RecordConfig? Config { get; init; }
}
