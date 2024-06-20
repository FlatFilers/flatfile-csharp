using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<AppType>))]
public enum AppType
{
    [EnumMember(Value = "PORTAL")]
    Portal,

    [EnumMember(Value = "PROJECTS")]
    Projects,

    [EnumMember(Value = "MAPPING")]
    Mapping,

    [EnumMember(Value = "WORKBOOKS")]
    Workbooks,

    [EnumMember(Value = "CUSTOM")]
    Custom
}
