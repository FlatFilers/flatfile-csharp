using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<Trigger>))]
public enum Trigger
{
    [EnumMember(Value = "manual")]
    Manual,

    [EnumMember(Value = "immediate")]
    Immediate
}
