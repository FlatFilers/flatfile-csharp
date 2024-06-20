using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UniqueConstraint
{
    [JsonPropertyName("config")]
    public UniqueConstraintConfig? Config { get; init; }
}
