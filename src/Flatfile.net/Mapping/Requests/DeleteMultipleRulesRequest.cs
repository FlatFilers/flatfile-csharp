using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class DeleteMultipleRulesRequest
{
    /// <summary>
    /// Array of rule IDs to be deleted
    /// </summary>
    [JsonPropertyName("ruleIds")]
    public IEnumerable<string> RuleIds { get; init; }
}
