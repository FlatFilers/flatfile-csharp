using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListGuestsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Guest> Data { get; init; }
}
