using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class WorkbookConfigSettings
{
    /// <summary>
    /// Whether to track changes for this workbook. Defaults to false. Tracking changes on a workbook allows for disabling workbook and sheet actions while data in the workbook is still being processed. You must run a recordHook listener if you enable this feature.
    /// </summary>
    [JsonPropertyName("trackChanges")]
    public bool? TrackChanges { get; init; }
}
