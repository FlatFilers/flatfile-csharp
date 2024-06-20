using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<Domain>))]
public enum Domain
{
    [EnumMember(Value = "file")]
    File,

    [EnumMember(Value = "space")]
    Space,

    [EnumMember(Value = "workbook")]
    Workbook,

    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "document")]
    Document,

    [EnumMember(Value = "sheet")]
    Sheet,

    [EnumMember(Value = "program")]
    Program,

    [EnumMember(Value = "secret")]
    Secret,

    [EnumMember(Value = "cron")]
    Cron,

    [EnumMember(Value = "environment")]
    Environment
}
