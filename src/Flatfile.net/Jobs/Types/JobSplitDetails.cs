using System.Text.Json.Serialization;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class JobSplitDetails
{
    [JsonPropertyName("parts")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<int, IEnumerable<Dictionary<string, object>>>>))]
    public OneOf<int, IEnumerable<Dictionary<string, object>>> Parts { get; init; }

    [JsonPropertyName("runInParallel")]
    public bool? RunInParallel { get; init; }
}
