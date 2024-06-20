using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class EventContextSlugs
{
    /// <summary>
    /// The slug of the space
    /// </summary>
    [JsonPropertyName("space")]
    public string? Space { get; init; }

    /// <summary>
    /// The slug of the workbook
    /// </summary>
    [JsonPropertyName("workbook")]
    public string? Workbook { get; init; }

    /// <summary>
    /// The slug of the sheet
    /// </summary>
    [JsonPropertyName("sheet")]
    public string? Sheet { get; init; }
}
