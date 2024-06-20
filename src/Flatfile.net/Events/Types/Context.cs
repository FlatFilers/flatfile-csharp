using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Context
{
    /// <summary>
    /// The namespaces of the event
    /// </summary>
    [JsonPropertyName("namespaces")]
    public IEnumerable<string>? Namespaces { get; init; }

    /// <summary>
    /// The slugs of related resources
    /// </summary>
    [JsonPropertyName("slugs")]
    public EventContextSlugs? Slugs { get; init; }

    [JsonPropertyName("actionName")]
    public string? ActionName { get; init; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; init; }

    [JsonPropertyName("environmentId")]
    public string EnvironmentId { get; init; }

    [JsonPropertyName("spaceId")]
    public string? SpaceId { get; init; }

    [JsonPropertyName("workbookId")]
    public string? WorkbookId { get; init; }

    [JsonPropertyName("sheetId")]
    public string? SheetId { get; init; }

    [JsonPropertyName("sheetSlug")]
    public string? SheetSlug { get; init; }

    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; init; }

    /// <summary>
    /// Deprecated, use `commitId` instead.
    /// </summary>
    [JsonPropertyName("versionId")]
    public string? VersionId { get; init; }

    [JsonPropertyName("commitId")]
    public string? CommitId { get; init; }

    [JsonPropertyName("jobId")]
    public string? JobId { get; init; }

    [JsonPropertyName("programId")]
    public string? ProgramId { get; init; }

    [JsonPropertyName("fileId")]
    public string? FileId { get; init; }

    [JsonPropertyName("documentId")]
    public string? DocumentId { get; init; }

    [JsonPropertyName("precedingEventId")]
    public string? PrecedingEventId { get; init; }

    /// <summary>
    /// Can be a UserId, GuestId, or AgentId
    /// </summary>
    [JsonPropertyName("actorId")]
    public string? ActorId { get; init; }

    [JsonPropertyName("appId")]
    public string? AppId { get; init; }
}
