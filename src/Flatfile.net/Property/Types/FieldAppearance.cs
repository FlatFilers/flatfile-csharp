using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class FieldAppearance
{
    [JsonPropertyName("size")]
    public FieldSize? Size { get; init; }
}
