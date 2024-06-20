using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ListUsersSortField>))]
public enum ListUsersSortField
{
    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "name")]
    Name,

    [EnumMember(Value = "id")]
    Id,

    [EnumMember(Value = "idp")]
    Idp,

    [EnumMember(Value = "idp_ref")]
    IdpRef,

    [EnumMember(Value = "created_at")]
    CreatedAt,

    [EnumMember(Value = "updated_at")]
    UpdatedAt,

    [EnumMember(Value = "last_seen_at")]
    LastSeenAt,

    [EnumMember(Value = "dashboard")]
    Dashboard
}
