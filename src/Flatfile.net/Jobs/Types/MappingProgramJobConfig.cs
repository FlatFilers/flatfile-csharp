using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class MappingProgramJobConfig
{
    [JsonPropertyName("sourceSheetId")]
    public string SourceSheetId { get; init; }

    [JsonPropertyName("destinationSheetId")]
    public string DestinationSheetId { get; init; }

    [JsonPropertyName("mappingRules")]
    public IEnumerable<Dictionary<string, object>> MappingRules { get; init; }
}
