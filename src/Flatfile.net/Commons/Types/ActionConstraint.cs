using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ActionConstraint
{
    [JsonPropertyName("type")]
    public ActionConstraintType Type { get; init; }
}
