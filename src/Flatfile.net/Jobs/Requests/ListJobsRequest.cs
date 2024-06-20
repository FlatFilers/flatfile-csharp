using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListJobsRequest
{
    /// <summary>
    /// When provided, only jobs for the given environment will be returned
    /// </summary>
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// When provided, only jobs for the given space will be returned
    /// </summary>
    public string? SpaceId { get; init; }

    /// <summary>
    /// When provided, only jobs for the given workbook will be returned
    /// </summary>
    public string? WorkbookId { get; init; }

    /// <summary>
    /// When provided, only jobs for the given file will be returned
    /// </summary>
    public string? FileId { get; init; }

    /// <summary>
    /// When provided, only jobs that are parts of the given job will be returned
    /// </summary>
    public string? ParentId { get; init; }

    /// <summary>
    /// Number of jobs to return in a page (default 20)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of jobs to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Sort direction - asc (ascending) or desc (descending)
    /// </summary>
    public SortDirection? SortDirection { get; init; }
}
