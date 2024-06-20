using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListUsersRequest
{
    /// <summary>
    /// Email of guest to return
    /// </summary>
    public string? Email { get; init; }

    /// <summary>
    /// String to search for users by name and email
    /// </summary>
    public string? Search { get; init; }

    /// <summary>
    /// Field to sort users by
    /// </summary>
    public ListUsersSortField? SortField { get; init; }

    /// <summary>
    /// Direction of sorting
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    /// <summary>
    /// Number of users to return in a page (default 20)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of users to return
    /// </summary>
    public int? PageNumber { get; init; }
}
