using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Environment
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; init; }

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
    public IEnumerable<GuestAuthenticationEnum> GuestAuthentication { get; init; }

    [JsonPropertyName("features")]
    public Dictionary<string, object> Features { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; init; }

    [JsonPropertyName("translationsPath")]
    public string? TranslationsPath { get; init; }

    [JsonPropertyName("namespaces")]
    public IEnumerable<string>? Namespaces { get; init; }

    [JsonPropertyName("languageOverride")]
    public string? LanguageOverride { get; init; }
}
