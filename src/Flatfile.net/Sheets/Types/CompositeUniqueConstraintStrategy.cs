using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<CompositeUniqueConstraintStrategy>))]
public enum CompositeUniqueConstraintStrategy
{
    [EnumMember(Value = "hash")]
    Hash,

    [EnumMember(Value = "concat")]
    Concat
}
