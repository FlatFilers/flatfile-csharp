using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetSnapshotRecordsRequest
{
    /// <summary>
    /// Number of records to return in a page
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of records to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Filter records by change type
    /// </summary>
    public ChangeType? ChangeType { get; init; }
}
