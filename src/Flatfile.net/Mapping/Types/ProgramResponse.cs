using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ProgramResponse
{
    [JsonPropertyName("data")]
    public Program Data { get; init; }
}
