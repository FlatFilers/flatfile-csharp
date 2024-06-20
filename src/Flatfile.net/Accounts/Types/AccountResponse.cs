using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class AccountResponse
{
    [JsonPropertyName("data")]
    public Account Data { get; init; }
}
