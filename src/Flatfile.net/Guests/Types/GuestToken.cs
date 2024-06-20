using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class GuestToken
{
    /// <summary>
    /// The token used to authenticate the guest
    /// </summary>
    [JsonPropertyName("token")]
    public string Token { get; init; }

    [JsonPropertyName("valid")]
    public bool Valid { get; init; }
}
