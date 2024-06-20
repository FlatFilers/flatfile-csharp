using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetRecordCountsRequest
{
    /// <summary>
    /// Returns records that were changed in that version and only those records.
    /// </summary>
    public string? VersionId { get; init; }

    /// <summary>
    /// Deprecated, use `sinceCommitId` instead.
    /// </summary>
    public string? SinceVersionId { get; init; }

    /// <summary>
    /// Returns records that were changed in that version in addition to any records from versions after that version.
    /// </summary>
    public string? CommitId { get; init; }

    /// <summary>
    /// Listing a commit ID here will return all records since the specified commit.
    /// </summary>
    public string? SinceCommitId { get; init; }

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
    /// If true, the counts for each field will also be returned
    /// </summary>
    public bool? ByField { get; init; }

    /// <summary>
    /// An FFQL query used to filter the result set to be counted
    /// </summary>
    public string? Q { get; init; }
}
