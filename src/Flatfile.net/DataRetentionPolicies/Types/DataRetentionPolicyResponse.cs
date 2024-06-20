using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DataRetentionPolicyResponse
{
    [JsonPropertyName("data")]
    public DataRetentionPolicy Data { get; init; }
}
