namespace Flatfile.net;

public class ListWorkbooksRequest
{
    /// <summary>
    /// The associated Space ID of the Workbook.
    /// </summary>
    public string? SpaceId { get; init; }

    /// <summary>
    /// Include counts for the workbook. **DEPRECATED** Counts will return 0s. Use GET /sheets/:sheetId/counts
    /// </summary>
    public bool? IncludeCounts { get; init; }
}
