using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<SortDirection>))]
public enum SortDirection
{
    [EnumMember(Value = "asc")]
    Asc,

    [EnumMember(Value = "desc")]
    Desc
}
