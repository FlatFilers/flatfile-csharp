using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class UserConfig
{
    [JsonPropertyName("email")]
    public string Email { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; init; }
}
