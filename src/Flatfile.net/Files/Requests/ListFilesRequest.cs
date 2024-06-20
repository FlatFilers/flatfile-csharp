using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListFilesRequest
{
    public string? SpaceId { get; init; }

    /// <summary>
    /// Number of files to return in a page (default 20)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of files to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The storage mode of file to fetch, defaults to "import"
    /// </summary>
    public Mode? Mode { get; init; }
}
