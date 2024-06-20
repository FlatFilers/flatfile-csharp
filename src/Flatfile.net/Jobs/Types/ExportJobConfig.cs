using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ExportJobConfig
{
    [JsonPropertyName("options")]
    public ExportOptions Options { get; init; }
}
