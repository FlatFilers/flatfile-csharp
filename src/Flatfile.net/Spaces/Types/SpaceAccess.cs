using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<SpaceAccess>))]
public enum SpaceAccess
{
    [EnumMember(Value = "*")]
    All,

    [EnumMember(Value = "upload")]
    Upload
}
