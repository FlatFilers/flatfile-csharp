using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<SheetAccess>))]
public enum SheetAccess
{
    [EnumMember(Value = "*")]
    All,

    [EnumMember(Value = "add")]
    Add,

    [EnumMember(Value = "edit")]
    Edit,

    [EnumMember(Value = "delete")]
    Delete,

    [EnumMember(Value = "import")]
    Import
}
