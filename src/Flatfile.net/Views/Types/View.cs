using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class View
{
    /// <summary>
    /// The ID of the view
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <summary>
    /// The associated sheet ID of the view
    /// </summary>
    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    /// <summary>
    /// The name of the view
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// The view filters of the view
    /// </summary>
    [JsonPropertyName("config")]
    public ViewConfig Config { get; init; }

    /// <summary>
    /// ID of the actor who created the view
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; init; }
}
