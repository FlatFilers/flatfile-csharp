using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class SnapshotResponse
{
    [JsonPropertyName("data")]
    public Snapshot Data { get; init; }
}
