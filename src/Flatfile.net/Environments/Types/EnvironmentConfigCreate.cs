using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EnvironmentConfigCreate
{
    /// <summary>
    /// The name of the environment
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// Whether or not the environment is a production environment
    /// </summary>
    [JsonPropertyName("isProd")]
    public bool IsProd { get; init; }

    [JsonPropertyName("guestAuthentication")]
    public IEnumerable<GuestAuthenticationEnum>? GuestAuthentication { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object>? Metadata { get; init; }

    [JsonPropertyName("translationsPath")]
    public string? TranslationsPath { get; init; }

    [JsonPropertyName("namespaces")]
    public IEnumerable<string>? Namespaces { get; init; }

    [JsonPropertyName("languageOverride")]
    public string? LanguageOverride { get; init; }
}
