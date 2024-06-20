using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextFileObject
{
    [JsonPropertyName("fileId")]
    public string FileId { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }
}
