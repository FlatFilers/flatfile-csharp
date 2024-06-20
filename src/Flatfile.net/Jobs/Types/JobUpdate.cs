using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class JobUpdate
{
    [JsonPropertyName("config")]
    [JsonConverter(
        typeof(OneOfSerializer<
            OneOf<
                DeleteRecordsJobConfig,
                FileJobConfig,
                PipelineJobConfig,
                ExportJobConfig,
                MutateJobConfig,
                FindAndReplaceJobConfig,
                MappingProgramJobConfig,
                EmptyObject
            >
        >)
    )]
    public OneOf<
        DeleteRecordsJobConfig,
        FileJobConfig,
        PipelineJobConfig,
        ExportJobConfig,
        MutateJobConfig,
        FindAndReplaceJobConfig,
        MappingProgramJobConfig,
        EmptyObject
    >? Config { get; init; }

    /// <summary>
    /// the status of the job
    /// </summary>
    [JsonPropertyName("status")]
    public JobStatus? Status { get; init; }

    /// <summary>
    /// the progress of the job. Whole number between 0 and 100
    /// </summary>
    [JsonPropertyName("progress")]
    public int? Progress { get; init; }

    /// <summary>
    /// the time that the job's outcome has been acknowledged by a user
    /// </summary>
    [JsonPropertyName("outcomeAcknowledgedAt")]
    public DateTime? OutcomeAcknowledgedAt { get; init; }

    /// <summary>
    /// Current status of job in text
    /// </summary>
    [JsonPropertyName("info")]
    public string? Info { get; init; }
}
