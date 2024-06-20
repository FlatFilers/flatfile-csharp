using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class FileResponse
{
    [JsonPropertyName("data")]
    public File Data { get; init; }
}
