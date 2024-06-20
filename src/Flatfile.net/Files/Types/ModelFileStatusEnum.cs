using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ModelFileStatusEnum>))]
public enum ModelFileStatusEnum
{
    [EnumMember(Value = "partial")]
    Partial,

    [EnumMember(Value = "complete")]
    Complete,

    [EnumMember(Value = "archived")]
    Archived,

    [EnumMember(Value = "purged")]
    Purged,

    [EnumMember(Value = "failed")]
    Failed
}
