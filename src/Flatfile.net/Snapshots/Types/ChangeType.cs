using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ChangeType>))]
public enum ChangeType
{
    [EnumMember(Value = "createdSince")]
    CreatedSince,

    [EnumMember(Value = "updatedSince")]
    UpdatedSince,

    [EnumMember(Value = "deletedSince")]
    DeletedSince
}
