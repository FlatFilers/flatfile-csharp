using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetRecordsResponseData
{
    [JsonPropertyName("records")]
    public IEnumerable<RecordWithLinks> Records { get; init; }

    [JsonPropertyName("counts")]
    public RecordCounts? Counts { get; init; }

    /// <summary>
    /// Deprecated, use `commitId` instead.
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; init; }

    [JsonPropertyName("commitId")]
    public string? CommitId { get; init; }

    [JsonPropertyName("success")]
    public bool Success { get; init; }
}
