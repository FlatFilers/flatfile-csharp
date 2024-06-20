using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobExecutionPlanConfig
{
    [JsonPropertyName("fieldMapping")]
    public IEnumerable<Edge>? FieldMapping { get; init; }

    [JsonPropertyName("unmappedSourceFields")]
    public IEnumerable<SourceField>? UnmappedSourceFields { get; init; }

    [JsonPropertyName("unmappedDestinationFields")]
    public IEnumerable<DestinationField>? UnmappedDestinationFields { get; init; }

    [JsonPropertyName("programId")]
    public string? ProgramId { get; init; }
}
