using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class PipelineJobConfig
{
    [JsonPropertyName("sourceSheetId")]
    public string SourceSheetId { get; init; }

    [JsonPropertyName("destinationSheetId")]
    public string DestinationSheetId { get; init; }
}
