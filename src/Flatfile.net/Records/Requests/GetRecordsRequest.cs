using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetRecordsRequest
{
    /// <summary>
    /// Deprecated, use `commitId` instead.
    /// </summary>
    public string? VersionId { get; init; }

    public string? CommitId { get; init; }

    /// <summary>
    /// Deprecated, use `sinceCommitId` instead.
    /// </summary>
    public string? SinceVersionId { get; init; }

    public string? SinceCommitId { get; init; }

    public string? SortField { get; init; }

    public SortDirection? SortDirection { get; init; }

    public Filter? Filter { get; init; }

    /// <summary>
    /// Name of field by which to filter records
    /// </summary>
    public string? FilterField { get; init; }

    public string? SearchValue { get; init; }

    public string? SearchField { get; init; }

    /// <summary>
    /// The Record Ids param (ids) is a list of record ids that can be passed to several record endpoints allowing the user to identify specific records to INCLUDE in the query, or specific records to EXCLUDE, depending on whether or not filters are being applied. When passing a query param that filters the record dataset, such as 'searchValue', or a 'filter' of 'valid' | 'error' | 'all', the 'ids' param will EXCLUDE those records from the filtered results. For basic queries that do not filter the dataset, passing record ids in the 'ids' param will limit the dataset to INCLUDE just those specific records. Maximum of 100 allowed.
    /// </summary>
    public string? Ids { get; init; }

    /// <summary>
    /// Number of records to return in a page (default 10,000)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of records to return (Note - numbers start at 1)
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// **DEPRECATED** Use GET /sheets/:sheetId/counts
    /// </summary>
    public bool? IncludeCounts { get; init; }

    /// <summary>
    /// The length of the record result set, returned as counts.total
    /// </summary>
    public bool? IncludeLength { get; init; }

    /// <summary>
    /// If true, linked records will be included in the results. Defaults to false.
    /// </summary>
    public bool? IncludeLinks { get; init; }

    /// <summary>
    /// Include error messages, defaults to false.
    /// </summary>
    public bool? IncludeMessages { get; init; }

    /// <summary>
    /// if "for" is provided, the query parameters will be pulled from the event payload
    /// </summary>
    public string? For { get; init; }

    /// <summary>
    /// An FFQL query used to filter the result set
    /// </summary>
    public string? Q { get; init; }
}
