using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ValidationType>))]
public enum ValidationType
{
    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "warn")]
    Warn,

    [EnumMember(Value = "info")]
    Info
}
