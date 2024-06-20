namespace Flatfile.net;

public class ListGuestsRequest
{
    /// <summary>
    /// ID of space to return
    /// </summary>
    public string SpaceId { get; init; }

    /// <summary>
    /// Email of guest to return
    /// </summary>
    public string? Email { get; init; }
}
