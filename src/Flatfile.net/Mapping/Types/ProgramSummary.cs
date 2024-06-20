using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class ProgramSummary
{
    /// <summary>
    /// Total number of mapping rules
    /// </summary>
    [JsonPropertyName("totalRuleCount")]
    public int TotalRuleCount { get; init; }

    /// <summary>
    /// Number of mapping rules added
    /// </summary>
    [JsonPropertyName("addedRuleCount")]
    public int AddedRuleCount { get; init; }

    /// <summary>
    /// Number of mapping rules deleted
    /// </summary>
    [JsonPropertyName("deletedRuleCount")]
    public int DeletedRuleCount { get; init; }
}
