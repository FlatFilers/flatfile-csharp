using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ViewConfig
{
    /// <summary>
    /// Deprecated, use `commitId` instead.
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; init; }

    [JsonPropertyName("commitId")]
    public string? CommitId { get; init; }

    /// <summary>
    /// Deprecated, use `sinceCommitId` instead.
    /// </summary>
    [JsonPropertyName("sinceVersionId")]
    public string? SinceVersionId { get; init; }

    [JsonPropertyName("sinceCommitId")]
    public string? SinceCommitId { get; init; }

    [JsonPropertyName("sortField")]
    public string? SortField { get; init; }

    [JsonPropertyName("sortDirection")]
    public SortDirection? SortDirection { get; init; }

    [JsonPropertyName("filter")]
    public Filter? Filter { get; init; }

    /// <summary>
    /// Name of field by which to filter records
    /// </summary>
    [JsonPropertyName("filterField")]
    public string? FilterField { get; init; }

    [JsonPropertyName("searchValue")]
    public string? SearchValue { get; init; }

    [JsonPropertyName("searchField")]
    public string? SearchField { get; init; }

    /// <summary>
    /// The Record Ids param (ids) is a list of record ids that can be passed to several record endpoints allowing the user to identify specific records to INCLUDE in the query, or specific records to EXCLUDE, depending on whether or not filters are being applied. When passing a query param that filters the record dataset, such as 'searchValue', or a 'filter' of 'valid' | 'error' | 'all', the 'ids' param will EXCLUDE those records from the filtered results. For basic queries that do not filter the dataset, passing record ids in the 'ids' param will limit the dataset to INCLUDE just those specific records. Maximum of 100 allowed.
    /// </summary>
    [JsonPropertyName("ids")]
    public IEnumerable<string>? Ids { get; init; }

    /// <summary>
    /// Number of records to return in a page (default 10,000)
    /// </summary>
    [JsonPropertyName("pageSize")]
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of records to return (Note - numbers start at 1)
    /// </summary>
    [JsonPropertyName("pageNumber")]
    public int? PageNumber { get; init; }

    /// <summary>
    /// **DEPRECATED** Use GET /sheets/:sheetId/counts
    /// </summary>
    [JsonPropertyName("includeCounts")]
    public bool? IncludeCounts { get; init; }

    /// <summary>
    /// The length of the record result set, returned as counts.total
    /// </summary>
    [JsonPropertyName("includeLength")]
    public bool? IncludeLength { get; init; }

    /// <summary>
    /// If true, linked records will be included in the results. Defaults to false.
    /// </summary>
    [JsonPropertyName("includeLinks")]
    public bool? IncludeLinks { get; init; }

    /// <summary>
    /// Include error messages, defaults to false.
    /// </summary>
    [JsonPropertyName("includeMessages")]
    public bool? IncludeMessages { get; init; }

    /// <summary>
    /// if "for" is provided, the query parameters will be pulled from the event payload
    /// </summary>
    [JsonPropertyName("for")]
    public string? For { get; init; }

    /// <summary>
    /// An FFQL query used to filter the result set
    /// </summary>
    [JsonPropertyName("q")]
    public string? Q { get; init; }
}
