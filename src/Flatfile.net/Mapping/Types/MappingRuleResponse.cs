using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class MappingRuleResponse
{
    [JsonPropertyName("data")]
    public MappingRule Data { get; init; }
}
