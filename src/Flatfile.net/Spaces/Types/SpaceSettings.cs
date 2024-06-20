using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SpaceSettings
{
    /// <summary>
    /// The sidebar configuration for the space. (This will eventually replace metadata.sidebarconfig)
    /// </summary>
    [JsonPropertyName("sidebarConfig")]
    public SpaceSidebarConfig? SidebarConfig { get; init; }
}
