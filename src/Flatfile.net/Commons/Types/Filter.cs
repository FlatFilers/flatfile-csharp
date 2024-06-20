using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<Filter>))]
public enum Filter
{
    [EnumMember(Value = "valid")]
    Valid,

    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "none")]
    None
}
