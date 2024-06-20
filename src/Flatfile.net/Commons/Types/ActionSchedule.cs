using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ActionSchedule>))]
public enum ActionSchedule
{
    [EnumMember(Value = "weekly")]
    Weekly,

    [EnumMember(Value = "daily")]
    Daily,

    [EnumMember(Value = "hourly")]
    Hourly
}
