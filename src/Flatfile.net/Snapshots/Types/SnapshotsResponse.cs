using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SnapshotsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Snapshot> Data { get; init; }
}
