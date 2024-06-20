using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<InputFormType>))]
public enum InputFormType
{
    [EnumMember(Value = "simple")]
    Simple
}
