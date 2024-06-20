using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<GetSpacesSortField>))]
public enum GetSpacesSortField
{
    [EnumMember(Value = "name")]
    Name,

    [EnumMember(Value = "workbooksCount")]
    WorkbooksCount,

    [EnumMember(Value = "filesCount")]
    FilesCount,

    [EnumMember(Value = "environmentId")]
    EnvironmentId,

    [EnumMember(Value = "createdByUserName")]
    CreatedByUserName,

    [EnumMember(Value = "createdAt")]
    CreatedAt
}
