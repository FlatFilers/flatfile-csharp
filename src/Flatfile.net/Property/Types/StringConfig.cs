using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class StringConfig
{
    [JsonPropertyName("size")]
    public StringConfigOptions Size { get; init; }
}
