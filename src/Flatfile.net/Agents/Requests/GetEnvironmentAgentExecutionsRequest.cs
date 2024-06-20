namespace Flatfile.net;

public class GetEnvironmentAgentExecutionsRequest
{
    public string EnvironmentId { get; init; }

    public string? SpaceId { get; init; }

    public bool? Success { get; init; }

    public int? PageSize { get; init; }

    public int? PageNumber { get; init; }
}
