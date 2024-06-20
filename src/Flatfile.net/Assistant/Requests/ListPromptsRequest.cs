namespace Flatfile.net;

public class ListPromptsRequest
{
    /// <summary>
    /// Number of prompts to return in a page (default 7)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of prompts to return
    /// </summary>
    public int? PageNumber { get; init; }
}
