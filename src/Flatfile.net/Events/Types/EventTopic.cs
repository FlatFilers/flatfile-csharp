using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<EventTopic>))]
public enum EventTopic
{
    [EnumMember(Value = "agent:created")]
    AgentCreated,

    [EnumMember(Value = "agent:updated")]
    AgentUpdated,

    [EnumMember(Value = "agent:deleted")]
    AgentDeleted,

    [EnumMember(Value = "space:created")]
    SpaceCreated,

    [EnumMember(Value = "space:updated")]
    SpaceUpdated,

    [EnumMember(Value = "space:deleted")]
    SpaceDeleted,

    [EnumMember(Value = "space:archived")]
    SpaceArchived,

    [EnumMember(Value = "space:expired")]
    SpaceExpired,

    [EnumMember(Value = "space:guestAdded")]
    SpaceGuestAdded,

    [EnumMember(Value = "space:guestRemoved")]
    SpaceGuestRemoved,

    [EnumMember(Value = "document:created")]
    DocumentCreated,

    [EnumMember(Value = "document:updated")]
    DocumentUpdated,

    [EnumMember(Value = "document:deleted")]
    DocumentDeleted,

    [EnumMember(Value = "workbook:created")]
    WorkbookCreated,

    [EnumMember(Value = "workbook:updated")]
    WorkbookUpdated,

    [EnumMember(Value = "workbook:deleted")]
    WorkbookDeleted,

    [EnumMember(Value = "workbook:expired")]
    WorkbookExpired,

    [EnumMember(Value = "sheet:created")]
    SheetCreated,

    [EnumMember(Value = "sheet:updated")]
    SheetUpdated,

    [EnumMember(Value = "sheet:deleted")]
    SheetDeleted,

    [EnumMember(Value = "sheet:counts-updated")]
    SheetCountsUpdated,

    [EnumMember(Value = "snapshot:created")]
    SnapshotCreated,

    [EnumMember(Value = "records:created")]
    RecordsCreated,

    [EnumMember(Value = "records:updated")]
    RecordsUpdated,

    [EnumMember(Value = "records:deleted")]
    RecordsDeleted,

    [EnumMember(Value = "file:created")]
    FileCreated,

    [EnumMember(Value = "file:updated")]
    FileUpdated,

    [EnumMember(Value = "file:deleted")]
    FileDeleted,

    [EnumMember(Value = "file:expired")]
    FileExpired,

    [EnumMember(Value = "job:created")]
    JobCreated,

    [EnumMember(Value = "job:updated")]
    JobUpdated,

    [EnumMember(Value = "job:deleted")]
    JobDeleted,

    [EnumMember(Value = "job:completed")]
    JobCompleted,

    [EnumMember(Value = "job:ready")]
    JobReady,

    [EnumMember(Value = "job:scheduled")]
    JobScheduled,

    [EnumMember(Value = "job:outcome-acknowledged")]
    JobOutcomeAcknowledged,

    [EnumMember(Value = "job:parts-completed")]
    JobPartsCompleted,

    [EnumMember(Value = "job:failed")]
    JobFailed,

    [EnumMember(Value = "program:created")]
    ProgramCreated,

    [EnumMember(Value = "program:updated")]
    ProgramUpdated,

    [EnumMember(Value = "commit:created")]
    CommitCreated,

    [EnumMember(Value = "commit:updated")]
    CommitUpdated,

    [EnumMember(Value = "commit:completed")]
    CommitCompleted,

    [EnumMember(Value = "layer:created")]
    LayerCreated,

    [EnumMember(Value = "secret:created")]
    SecretCreated,

    [EnumMember(Value = "secret:updated")]
    SecretUpdated,

    [EnumMember(Value = "secret:deleted")]
    SecretDeleted,

    [EnumMember(Value = "cron:5-minutes")]
    Cron5Minutes,

    [EnumMember(Value = "cron:hourly")]
    CronHourly,

    [EnumMember(Value = "cron:daily")]
    CronDaily,

    [EnumMember(Value = "cron:weekly")]
    CronWeekly,

    [EnumMember(Value = "environment:created")]
    EnvironmentCreated,

    [EnumMember(Value = "environment:updated")]
    EnvironmentUpdated,

    [EnumMember(Value = "environment:deleted")]
    EnvironmentDeleted
}
