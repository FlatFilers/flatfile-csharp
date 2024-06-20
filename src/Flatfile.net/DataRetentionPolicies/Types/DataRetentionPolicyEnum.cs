using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<DataRetentionPolicyEnum>))]
public enum DataRetentionPolicyEnum
{
    [EnumMember(Value = "lastActivity")]
    LastActivity,

    [EnumMember(Value = "sinceCreated")]
    SinceCreated
}
