using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class ListUsersResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<User> Data { get; init; }

    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}
