using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<StringConfigOptions>))]
public enum StringConfigOptions
{
    [EnumMember(Value = "tiny")]
    Tiny,

    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "medium")]
    Medium,

    [EnumMember(Value = "long")]
    Long
}
