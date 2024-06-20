namespace Flatfile.net;

public class ListViewsRequest
{
    /// <summary>
    /// The associated sheet ID of the view.
    /// </summary>
    public string SheetId { get; init; }

    /// <summary>
    /// Number of prompts to return in a page (default 10)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of prompts to return
    /// </summary>
    public int? PageNumber { get; init; }
}
