namespace Flatfile.net;

public class GetEventTokenRequest
{
    /// <summary>
    /// The resource ID of the event stream (space or environment id)
    /// </summary>
    public string? Scope { get; init; }

    /// <summary>
    /// The space ID of the event stream
    /// </summary>
    public string? SpaceId { get; init; }
}
