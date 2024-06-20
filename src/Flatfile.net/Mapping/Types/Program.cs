using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Program
{
    /// <summary>
    /// Mapping rules
    /// </summary>
    [JsonPropertyName("rules")]
    public IEnumerable<MappingRuleOrConfig> Rules { get; init; }

    /// <summary>
    /// If this program was saved, this is the ID of the program
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// Namespace of the program
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Family ID of the program, if it belongs to a family
    /// </summary>
    [JsonPropertyName("familyId")]
    public string? FamilyId { get; init; }

    /// <summary>
    /// If this program was saved, this is the time it was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// If this program was saved, this is the user ID of the creator
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; init; }

    /// <summary>
    /// Source keys
    /// </summary>
    [JsonPropertyName("sourceKeys")]
    public IEnumerable<string> SourceKeys { get; init; }

    /// <summary>
    /// Destination keys
    /// </summary>
    [JsonPropertyName("destinationKeys")]
    public IEnumerable<string> DestinationKeys { get; init; }

    /// <summary>
    /// Summary of the mapping rules
    /// </summary>
    [JsonPropertyName("summary")]
    public ProgramSummary? Summary { get; init; }

    /// <summary>
    /// If this program was saved, this token allows you to modify the program
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }
}
