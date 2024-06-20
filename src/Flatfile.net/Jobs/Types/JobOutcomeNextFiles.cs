using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextFiles
{
    [JsonPropertyName("files")]
    public IEnumerable<JobOutcomeNextFileObject> Files { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }
}
