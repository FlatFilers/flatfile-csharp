using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<JobPartExecution>))]
public enum JobPartExecution
{
    [EnumMember(Value = "sequential")]
    Sequential,

    [EnumMember(Value = "parallel")]
    Parallel
}
