using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobPlan
{
    [JsonPropertyName("job")]
    public Job Job { get; init; }

    [JsonPropertyName("plan")]
    public JobExecutionPlan Plan { get; init; }
}
