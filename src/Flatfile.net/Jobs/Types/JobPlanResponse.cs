using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobPlanResponse
{
    [JsonPropertyName("data")]
    public JobPlan Data { get; init; }
}
