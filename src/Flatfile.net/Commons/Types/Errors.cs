using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Errors
{
    [JsonPropertyName("errors")]
    public IEnumerable<Error> Errors_ { get; init; }
}
