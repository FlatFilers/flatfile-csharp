using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<FileOrigin>))]
public enum FileOrigin
{
    [EnumMember(Value = "filesystem")]
    Filesystem,

    [EnumMember(Value = "googledrive")]
    Googledrive,

    [EnumMember(Value = "box")]
    Box,

    [EnumMember(Value = "onedrive")]
    Onedrive
}
