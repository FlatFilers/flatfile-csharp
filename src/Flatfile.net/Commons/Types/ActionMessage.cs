using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ActionMessage
{
    [JsonPropertyName("type")]
    public ActionMessageType Type { get; init; }

    [JsonPropertyName("content")]
    public string Content { get; init; }
}
