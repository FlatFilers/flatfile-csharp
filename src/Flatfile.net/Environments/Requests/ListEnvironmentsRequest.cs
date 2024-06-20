namespace Flatfile.net;

public class ListEnvironmentsRequest
{
    /// <summary>
    /// Number of environments to return in a page (default 10)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of environments to return
    /// </summary>
    public int? PageNumber { get; init; }
}
