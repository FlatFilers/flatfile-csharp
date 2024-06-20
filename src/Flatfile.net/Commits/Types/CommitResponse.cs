using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CommitResponse
{
    [JsonPropertyName("data")]
    public Commit Data { get; init; }
}
