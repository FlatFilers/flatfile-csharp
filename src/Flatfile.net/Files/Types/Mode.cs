using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<Mode>))]
public enum Mode
{
    [EnumMember(Value = "import")]
    Import,

    [EnumMember(Value = "export")]
    Export
}
