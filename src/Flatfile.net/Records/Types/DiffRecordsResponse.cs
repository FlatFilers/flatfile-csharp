using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class DiffRecordsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<DiffRecord> Data { get; init; }
}
