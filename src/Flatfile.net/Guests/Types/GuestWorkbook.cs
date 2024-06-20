using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class GuestWorkbook
{
    [JsonPropertyName("id")]
    public string Id { get; init; }
}
