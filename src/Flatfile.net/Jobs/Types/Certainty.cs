using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;

#nullable enable

namespace Flatfile.net;

[JsonConverter(typeof(StringEnumSerializer<Certainty>))]
public enum Certainty
{
    [EnumMember(Value = "absolute")]
    Absolute,

    [EnumMember(Value = "strong")]
    Strong,

    [EnumMember(Value = "moderate")]
    Moderate,

    [EnumMember(Value = "weak")]
    Weak
}
