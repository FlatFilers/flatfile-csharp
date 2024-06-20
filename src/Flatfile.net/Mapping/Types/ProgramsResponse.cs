using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ProgramsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Program> Data { get; init; }
}
