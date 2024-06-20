namespace Flatfile.net;

public class ListProgramsRequest
{
    /// <summary>
    /// Number of programs to return in a page (default 10)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of records to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Filter by creator
    /// </summary>
    public string? CreatedBy { get; init; }

    /// <summary>
    /// Filter by creation time
    /// </summary>
    public DateTime? CreatedAfter { get; init; }

    /// <summary>
    /// Filter by creation time
    /// </summary>
    public DateTime? CreatedBefore { get; init; }

    /// <summary>
    /// The ID of the environment
    /// </summary>
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// Filter by family
    /// </summary>
    public string? FamilyId { get; init; }

    /// <summary>
    /// Filter by namespace
    /// </summary>
    public string? Namespace { get; init; }

    /// <summary>
    /// Filter by source keys
    /// </summary>
    public string? SourceKeys { get; init; }

    /// <summary>
    /// Filter by destination keys
    /// </summary>
    public string? DestinationKeys { get; init; }
}
