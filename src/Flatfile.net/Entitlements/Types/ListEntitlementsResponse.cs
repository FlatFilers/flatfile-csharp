using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListEntitlementsResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<Entitlement> Data { get; init; }
}
