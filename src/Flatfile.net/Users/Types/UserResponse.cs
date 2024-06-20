using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UserResponse
{
    [JsonPropertyName("data")]
    public User Data { get; init; }
}
