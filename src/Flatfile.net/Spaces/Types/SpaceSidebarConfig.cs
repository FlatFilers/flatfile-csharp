using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class SpaceSidebarConfig
{
    /// <summary>
    /// Used to set the order of workbooks in the sidebar. This will not affect workbooks that are pinned and workbooks that are not specified here will be sorted alphabetically.
    /// </summary>
    [JsonPropertyName("workbookSidebarOrder")]
    public IEnumerable<string>? WorkbookSidebarOrder { get; init; }
}
