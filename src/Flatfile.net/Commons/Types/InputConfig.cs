using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class InputConfig
{
    [JsonPropertyName("options")]
    public IEnumerable<InputEnumPropertyOption> Options { get; init; }
}
