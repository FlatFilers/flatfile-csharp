using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<FieldSize>))]
public enum FieldSize
{
    [EnumMember(Value = "xs")]
    Xs,

    [EnumMember(Value = "s")]
    S,

    [EnumMember(Value = "m")]
    M,

    [EnumMember(Value = "l")]
    L,

    [EnumMember(Value = "xl")]
    Xl
}
