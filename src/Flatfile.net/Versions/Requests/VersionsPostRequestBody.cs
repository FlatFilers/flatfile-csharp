using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class VersionsPostRequestBody
{
    /// <summary>
    /// The ID of the Sheet.
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string? SheetId { get; init; }

    /// <summary>
    /// Deprecated, creating or updating a group of records together will automatically generate a commitId to group those record changes together.
    /// </summary>
    [JsonPropertyName("parentVersionId")]
    public string? ParentVersionId { get; init; }
}
