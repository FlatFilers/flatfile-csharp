using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class InternalSpaceConfigBase
{
    [JsonPropertyName("spaceConfigId")]
    public string? SpaceConfigId { get; init; }

    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// The ID of the primary workbook for the space. This should not be included in create space requests.
    /// </summary>
    [JsonPropertyName("primaryWorkbookId")]
    public string? PrimaryWorkbookId { get; init; }

    /// <summary>
    /// Metadata for the space
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; init; }

    /// <summary>
    /// The Space settings.
    /// </summary>
    [JsonPropertyName("settings")]
    public SpaceSettings? Settings { get; init; }

    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }

    [JsonPropertyName("access")]
    public IEnumerable<SpaceAccess>? Access { get; init; }

    [JsonPropertyName("autoConfigure")]
    public bool? AutoConfigure { get; init; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; init; }

    [JsonPropertyName("labels")]
    public IEnumerable<string>? Labels { get; init; }

    [JsonPropertyName("translationsPath")]
    public string? TranslationsPath { get; init; }

    [JsonPropertyName("languageOverride")]
    public string? LanguageOverride { get; init; }

    /// <summary>
    /// Date when space was archived
    /// </summary>
    [JsonPropertyName("archivedAt")]
    public DateTime? ArchivedAt { get; init; }

    /// <summary>
    /// The ID of the App that space is associated with
    /// </summary>
    [JsonPropertyName("appId")]
    public string? AppId { get; init; }
}
