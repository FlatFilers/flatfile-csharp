using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class File
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// Original filename
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Extension of the file
    /// </summary>
    [JsonPropertyName("ext")]
    public string Ext { get; init; }

    /// <summary>
    /// MIME Type of the file
    /// </summary>
    [JsonPropertyName("mimetype")]
    public string Mimetype { get; init; }

    /// <summary>
    /// Text encoding of the file
    /// </summary>
    [JsonPropertyName("encoding")]
    public string Encoding { get; init; }

    /// <summary>
    /// Status of the file
    /// </summary>
    [JsonPropertyName("status")]
    public ModelFileStatusEnum Status { get; init; }

    /// <summary>
    /// The storage mode of file
    /// </summary>
    [JsonPropertyName("mode")]
    public Mode? Mode { get; init; }

    /// <summary>
    /// Size of file in bytes
    /// </summary>
    [JsonPropertyName("size")]
    public int Size { get; init; }

    /// <summary>
    /// Number of bytes that have been uploaded so far (useful for progress tracking)
    /// </summary>
    [JsonPropertyName("bytesReceived")]
    public int BytesReceived { get; init; }

    /// <summary>
    /// Date the file was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    /// <summary>
    /// Date the file was last updated
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    /// <summary>
    /// Date the file was expired
    /// </summary>
    [JsonPropertyName("expiredAt")]
    public DateTime? ExpiredAt { get; init; }

    [JsonPropertyName("spaceId")]
    public string SpaceId { get; init; }

    [JsonPropertyName("workbookId")]
    public string? WorkbookId { get; init; }

    [JsonPropertyName("sheetId")]
    public string? SheetId { get; init; }

    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }

    [JsonPropertyName("origin")]
    public FileOrigin? Origin { get; init; }
}
