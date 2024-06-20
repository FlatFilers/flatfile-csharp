using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListSpacesRequest
{
    /// <summary>
    /// The ID of the environment.
    /// </summary>
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// Number of spaces to return in a page (default 10)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of records to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Search query for spaces
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Search by namespace
    /// </summary>
    public string? Namespace { get; init; }

    /// <summary>
    /// Flag to include archived spaces
    /// </summary>
    public bool? Archived { get; init; }

    /// <summary>
    /// Field to sort spaces by
    /// </summary>
    public GetSpacesSortField? SortField { get; init; }

    /// <summary>
    /// Direction of sorting
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    /// <summary>
    /// Flag for collaborative (project) spaces
    /// </summary>
    public bool? IsCollaborative { get; init; }
}
