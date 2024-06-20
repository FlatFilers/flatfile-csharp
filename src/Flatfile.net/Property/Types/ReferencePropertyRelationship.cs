using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ReferencePropertyRelationship>))]
public enum ReferencePropertyRelationship
{
    [EnumMember(Value = "has-one")]
    HasOne,

    [EnumMember(Value = "has-many")]
    HasMany
}
