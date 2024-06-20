using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<InputConstraintType>))]
public enum InputConstraintType
{
    [EnumMember(Value = "required")]
    Required
}
