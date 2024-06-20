using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ProgramConfig
{
    /// <summary>
    /// Source schema
    /// </summary>
    [JsonPropertyName("source")]
    public SheetConfig Source { get; init; }

    /// <summary>
    /// Destination schema
    /// </summary>
    [JsonPropertyName("destination")]
    public SheetConfig Destination { get; init; }

    /// <summary>
    /// ID of the family to add the program to
    /// </summary>
    [JsonPropertyName("familyId")]
    public string? FamilyId { get; init; }

    /// <summary>
    /// Namespace of the program
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    /// <summary>
    /// Whether to save the program for editing later. Defaults to false. If true, the response will contain an ID and access token.
    /// </summary>
    [JsonPropertyName("save")]
    public bool? Save { get; init; }
}
