using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Success
{
    [JsonPropertyName("data")]
    public SuccessData? Data { get; init; }
}
