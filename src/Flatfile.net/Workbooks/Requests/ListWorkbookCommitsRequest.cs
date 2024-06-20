namespace Flatfile.net;

public class ListWorkbookCommitsRequest
{
    /// <summary>
    /// If true, only return commits that have been completed. If false, only return commits that have not been completed. If not provided, return all commits.
    /// </summary>
    public bool? Completed { get; init; }
}
