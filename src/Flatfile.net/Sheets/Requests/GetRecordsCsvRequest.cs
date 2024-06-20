using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetRecordsCsvRequest
{
    /// <summary>
    /// Deprecated, use `sinceCommitId` instead.
    /// </summary>
    public string? VersionId { get; init; }

    /// <summary>
    /// Returns records that were changed in that version in that version and only those records.
    /// </summary>
    public string? CommitId { get; init; }

    /// <summary>
    /// Deprecated, use `sinceCommitId` instead.
    /// </summary>
    public string? SinceVersionId { get; init; }

    /// <summary>
    /// Returns records that were changed in that version in addition to any records from versions after that version.
    /// </summary>
    public string? SinceCommitId { get; init; }

    /// <summary>
    /// The field to sort the data on.
    /// </summary>
    public string? SortField { get; init; }

    /// <summary>
    /// Sort direction - asc (ascending) or desc (descending)
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    /// <summary>
    /// Options to filter records
    /// </summary>
    public Filter? Filter { get; init; }

    /// <summary>
    /// The field to filter the data on.
    /// </summary>
    public string? FilterField { get; init; }

    /// <summary>
    /// The value to search for data on.
    /// </summary>
    public string? SearchValue { get; init; }

    /// <summary>
    /// The field to search for data on.
    /// </summary>
    public string? SearchField { get; init; }

    /// <summary>
    /// The Record Ids param (ids) is a list of record ids that can be passed to several record endpoints allowing the user to identify specific records to INCLUDE in the query, or specific records to EXCLUDE, depending on whether or not filters are being applied. When passing a query param that filters the record dataset, such as 'searchValue', or a 'filter' of 'valid' | 'error' | 'all', the 'ids' param will EXCLUDE those records from the filtered results. For basic queries that do not filter the dataset, passing record ids in the 'ids' param will limit the dataset to INCLUDE just those specific records
    /// </summary>
    public string? Ids { get; init; }
}
