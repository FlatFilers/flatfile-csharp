using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class UpdateFileRequest
{
    [JsonPropertyName("workbookId")]
    public string? WorkbookId { get; init; }

    /// <summary>
    /// The name of the file
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The storage mode of file to update
    /// </summary>
    [JsonPropertyName("mode")]
    public Mode? Mode { get; init; }

    /// <summary>
    /// Status of the file
    /// </summary>
    [JsonPropertyName("status")]
    public ModelFileStatusEnum? Status { get; init; }

    /// <summary>
    /// The actions attached to the file
    /// </summary>
    [JsonPropertyName("actions")]
    public IEnumerable<Action>? Actions { get; init; }
}
