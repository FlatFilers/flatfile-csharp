using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GuestConfigUpdate
{
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }

    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("spaces")]
    public IEnumerable<GuestSpace>? Spaces { get; init; }
}
