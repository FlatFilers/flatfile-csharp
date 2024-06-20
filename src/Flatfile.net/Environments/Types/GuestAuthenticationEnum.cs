using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<GuestAuthenticationEnum>))]
public enum GuestAuthenticationEnum
{
    [EnumMember(Value = "shared_link")]
    SharedLink,

    [EnumMember(Value = "magic_link")]
    MagicLink
}
