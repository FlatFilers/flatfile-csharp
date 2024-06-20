using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<ActionMode>))]
public enum ActionMode
{
    [EnumMember(Value = "foreground")]
    Foreground,

    [EnumMember(Value = "background")]
    Background,

    [EnumMember(Value = "toolbarBlocking")]
    ToolbarBlocking
}
