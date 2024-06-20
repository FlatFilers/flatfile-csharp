using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<JobStatus>))]
public enum JobStatus
{
    [EnumMember(Value = "created")]
    Created,

    [EnumMember(Value = "planning")]
    Planning,

    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "ready")]
    Ready,

    [EnumMember(Value = "executing")]
    Executing,

    [EnumMember(Value = "complete")]
    Complete,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "canceled")]
    Canceled,

    [EnumMember(Value = "waiting")]
    Waiting
}
