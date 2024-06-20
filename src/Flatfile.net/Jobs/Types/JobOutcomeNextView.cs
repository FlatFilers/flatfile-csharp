using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class JobOutcomeNextView
{
    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    /// <summary>
    /// An array of field keys from the sheet
    /// </summary>
    [JsonPropertyName("hiddenColumns")]
    public IEnumerable<string> HiddenColumns { get; init; }

    [JsonPropertyName("label")]
    public string? Label { get; init; }
}
