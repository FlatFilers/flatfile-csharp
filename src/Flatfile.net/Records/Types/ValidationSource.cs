using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ValidationSource>))]
public enum ValidationSource
{
    [EnumMember(Value = "required-constraint")]
    RequiredConstraint,

    [EnumMember(Value = "unique-constraint")]
    UniqueConstraint,

    [EnumMember(Value = "custom-logic")]
    CustomLogic,

    [EnumMember(Value = "unlinked")]
    Unlinked,

    [EnumMember(Value = "invalid-option")]
    InvalidOption,

    [EnumMember(Value = "is-artifact")]
    IsArtifact
}
