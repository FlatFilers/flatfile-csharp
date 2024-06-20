using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DocumentConfig
{
    [JsonPropertyName("title")]
    public string Title { get; init; }

    [JsonPropertyName("body")]
    public string Body { get; init; }

    /// <summary>
    /// Certain treatments will cause your Document to look or behave differently.
    /// </summary>
    [JsonPropertyName("treatments")]
    public IEnumerable<string>? Treatments { get; init; }

    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }
}
