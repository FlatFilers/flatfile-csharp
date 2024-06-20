using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListCommitsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Commit> Data { get; init; }
}
