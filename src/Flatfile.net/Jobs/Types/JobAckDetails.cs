using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobAckDetails
{
    [JsonPropertyName("info")]
    public string? Info { get; init; }

    /// <summary>
    /// the progress of the job. Whole number between 0 and 100
    /// </summary>
    [JsonPropertyName("progress")]
    public int? Progress { get; init; }

    [JsonPropertyName("estimatedCompletionAt")]
    public DateTime? EstimatedCompletionAt { get; init; }
}
