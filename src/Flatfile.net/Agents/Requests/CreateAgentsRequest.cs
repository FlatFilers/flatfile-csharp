using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CreateAgentsRequest
{
    public string EnvironmentId { get; init; }

    public AgentConfig Body { get; init; }
}
