using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class MappingRulesResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<MappingRule> Data { get; init; }
}
