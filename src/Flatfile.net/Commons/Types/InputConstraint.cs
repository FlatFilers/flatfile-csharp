using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class InputConstraint
{
    [JsonPropertyName("type")]
    public InputConstraintType Type { get; init; }
}
