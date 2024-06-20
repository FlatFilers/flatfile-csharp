using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<JobType>))]
public enum JobType
{
    [EnumMember(Value = "file")]
    File,

    [EnumMember(Value = "workbook")]
    Workbook,

    [EnumMember(Value = "sheet")]
    Sheet,

    [EnumMember(Value = "space")]
    Space,

    [EnumMember(Value = "document")]
    Document
}
