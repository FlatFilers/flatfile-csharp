using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class AccountPatch
{
    [JsonPropertyName("defaultAppId")]
    public string DefaultAppId { get; init; }
}
