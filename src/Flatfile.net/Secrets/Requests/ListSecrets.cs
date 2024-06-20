namespace Flatfile.net;

public class ListSecrets
{
    /// <summary>
    /// The Environment of the secret.
    /// </summary>
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// The Space of the secret.
    /// </summary>
    public string? SpaceId { get; init; }
}
