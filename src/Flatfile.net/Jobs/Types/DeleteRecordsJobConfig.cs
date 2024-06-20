using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DeleteRecordsJobConfig
{
    /// <summary>
    /// Options to filter records (default=none)
    /// </summary>
    [JsonPropertyName("filter")]
    public Filter? Filter { get; init; }

    /// <summary>
    /// Use this to narrow the valid/error filter results to a specific field (Requires filter to be set)
    /// </summary>
    [JsonPropertyName("filterField")]
    public string? FilterField { get; init; }

    [JsonPropertyName("searchValue")]
    public string? SearchValue { get; init; }

    [JsonPropertyName("searchField")]
    public string? SearchField { get; init; }

    /// <summary>
    /// FFQL query to filter records
    /// </summary>
    [JsonPropertyName("q")]
    public string? Q { get; init; }

    [JsonPropertyName("sheet")]
    public string Sheet { get; init; }

    /// <summary>
    /// List of record ids to exclude from deletion
    /// </summary>
    [JsonPropertyName("exceptions")]
    public IEnumerable<string>? Exceptions { get; init; }
}
