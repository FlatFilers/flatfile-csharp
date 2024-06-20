using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Version
{
    [JsonPropertyName("versionId")]
    public string VersionId { get; init; }
}
