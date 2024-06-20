using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class JobConfig
{
    /// <summary>
    /// The type of job
    /// </summary>
    [JsonPropertyName("type")]
    public JobType Type { get; init; }

    /// <summary>
    /// the type of operation to perform on the data. For example, "export".
    /// </summary>
    [JsonPropertyName("operation")]
    public string Operation { get; init; }

    [JsonPropertyName("source")]
    public string Source { get; init; }

    [JsonPropertyName("destination")]
    public string? Destination { get; init; }

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
    /// the type of trigger to use for this job
    /// </summary>
    [JsonPropertyName("trigger")]
    public Trigger? Trigger { get; init; }

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

    [JsonPropertyName("fileId")]
    public string? FileId { get; init; }

    /// <summary>
    /// the mode of the job
    /// </summary>
    [JsonPropertyName("mode")]
    public JobMode? Mode { get; init; }

    /// <summary>
    /// Input parameters for this job type.
    /// </summary>
    [JsonPropertyName("input")]
    public Dictionary<string, object>? Input { get; init; }

    /// <summary>
    /// Subject parameters for this job type.
    /// </summary>
    [JsonPropertyName("subject")]
    public object? Subject { get; init; }

    /// <summary>
    /// Outcome summary of job.
    /// </summary>
    [JsonPropertyName("outcome")]
    public Dictionary<string, object>? Outcome { get; init; }

    /// <summary>
    /// Current status of job in text
    /// </summary>
    [JsonPropertyName("info")]
    public string? Info { get; init; }

    /// <summary>
    /// Indicates if Flatfile is managing the control flow of this job or if it is being manually tracked.
    /// </summary>
    [JsonPropertyName("managed")]
    public bool? Managed { get; init; }

    /// <summary>
    /// The id of the environment this job belongs to
    /// </summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; init; }

    /// <summary>
    /// The part number of this job
    /// </summary>
    [JsonPropertyName("part")]
    public int? Part { get; init; }

    /// <summary>
    /// The data for this part of the job
    /// </summary>
    [JsonPropertyName("partData")]
    public Dictionary<string, object>? PartData { get; init; }

    /// <summary>
    /// The execution mode for this part of the job
    /// </summary>
    [JsonPropertyName("partExecution")]
    public JobPartExecution? PartExecution { get; init; }

    /// <summary>
    /// The id of the parent job
    /// </summary>
    [JsonPropertyName("parentId")]
    public string? ParentId { get; init; }

    /// <summary>
    /// The ids of the jobs that must complete before this job can start
    /// </summary>
    [JsonPropertyName("predecessorIds")]
    public IEnumerable<string>? PredecessorIds { get; init; }
}
