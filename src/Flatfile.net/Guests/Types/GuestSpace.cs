using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GuestSpace
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("workbooks")]
    public IEnumerable<GuestWorkbook>? Workbooks { get; init; }

    [JsonPropertyName("lastAccessed")]
    public DateTime? LastAccessed { get; init; }
}
