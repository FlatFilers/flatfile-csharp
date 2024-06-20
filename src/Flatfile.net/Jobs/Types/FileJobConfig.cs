using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class FileJobConfig
{
    /// <summary>
    /// The driver to use for extracting data from the file
    /// </summary>
    [JsonPropertyName("driver")]
    public Driver Driver { get; init; }

    /// <summary>
    /// The options to use for extracting data from the file
    /// </summary>
    [JsonPropertyName("options")]
    public Dictionary<string, object>? Options { get; init; }
}
