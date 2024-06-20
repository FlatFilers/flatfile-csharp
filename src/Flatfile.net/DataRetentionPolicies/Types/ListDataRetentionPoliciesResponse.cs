using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListDataRetentionPoliciesResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<DataRetentionPolicy> Data { get; init; }
}
