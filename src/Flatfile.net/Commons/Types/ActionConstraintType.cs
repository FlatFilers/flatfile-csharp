using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ActionConstraintType>))]
public enum ActionConstraintType
{
    [EnumMember(Value = "hasAllValid")]
    HasAllValid,

    [EnumMember(Value = "hasSelection")]
    HasSelection,

    [EnumMember(Value = "hasData")]
    HasData
}
