using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ActionMessageType>))]
public enum ActionMessageType
{
    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "info")]
    Info
}
