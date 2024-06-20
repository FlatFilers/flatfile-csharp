using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Space
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Amount of workbooks in the space
    /// </summary>
    [JsonPropertyName("workbooksCount")]
    public int? WorkbooksCount { get; init; }

    /// <summary>
    /// Amount of files in the space
    /// </summary>
    [JsonPropertyName("filesCount")]
    public int? FilesCount { get; init; }

    [JsonPropertyName("createdByUserId")]
    public string? CreatedByUserId { get; init; }

    /// <summary>
    /// User name who created space
    /// </summary>
    [JsonPropertyName("createdByUserName")]
    public string? CreatedByUserName { get; init; }

    /// <summary>
    /// Date when space was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Date when space was updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    /// <summary>
    /// Date when space was expired
    /// </summary>
    [JsonPropertyName("expiredAt")]
    public DateTime? ExpiredAt { get; init; }

    /// <summary>
    /// This date marks the most recent activity within the space, tracking actions to the second. Activities include creating or updating records in a sheet, uploading files, or modifying a workbook's configuration.
    /// </summary>
    [JsonPropertyName("lastActivityAt")]
    public DateTime? LastActivityAt { get; init; }

    /// <summary>
    /// Guest link to the space
    /// </summary>
    [JsonPropertyName("guestLink")]
    public string? GuestLink { get; init; }

    /// <summary>
    /// The name of the space
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// The display order
    /// </summary>
    [JsonPropertyName("displayOrder")]
    public int? DisplayOrder { get; init; }

    /// <summary>
    /// Access token for the space
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; init; }

    /// <summary>
    /// Flag for collaborative (project) spaces
    /// </summary>
    [JsonPropertyName("isCollaborative")]
    public bool? IsCollaborative { get; init; }

    /// <summary>
    /// Size information for the space
    /// </summary>
    [JsonPropertyName("size")]
    public SpaceSize? Size { get; init; }

    /// <summary>
    /// Date when the space was upgraded
    /// </summary>
    [JsonPropertyName("upgradedAt")]
    public DateTime? UpgradedAt { get; init; }

    /// <summary>
    /// Type of guest authentication
    /// </summary>
    [JsonPropertyName("guestAuthentication")]
    public IEnumerable<GuestAuthenticationEnum> GuestAuthentication { get; init; }

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
