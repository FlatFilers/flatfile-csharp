namespace Flatfile.net;

public class ListEventsRequest
{
    /// <summary>
    /// Filter by environment
    /// </summary>
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// Filter by space
    /// </summary>
    public string? SpaceId { get; init; }

    /// <summary>
    /// Filter by event domain
    /// </summary>
    public string? Domain { get; init; }

    /// <summary>
    /// Filter by event topic
    /// </summary>
    public string? Topic { get; init; }

    /// <summary>
    /// Filter by event timestamp
    /// </summary>
    public DateTime? Since { get; init; }

    /// <summary>
    /// Number of results to return in a page (default 10)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of results to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Include acknowledged events
    /// </summary>
    public bool? IncludeAcknowledged { get; init; }
}
