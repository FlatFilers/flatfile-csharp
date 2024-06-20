using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class InputForm
{
    [JsonPropertyName("type")]
    public InputFormType Type { get; init; }

    [JsonPropertyName("fields")]
    public IEnumerable<InputField> Fields { get; init; }
}
