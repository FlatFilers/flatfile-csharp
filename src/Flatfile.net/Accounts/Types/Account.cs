using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Account
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("subdomain")]
    public string? Subdomain { get; init; }

    [JsonPropertyName("vanityDomainDashboard")]
    public string? VanityDomainDashboard { get; init; }

    [JsonPropertyName("vanityDomainSpaces")]
    public string? VanityDomainSpaces { get; init; }

    [JsonPropertyName("embeddedDomainWhitelist")]
    public IEnumerable<string>? EmbeddedDomainWhitelist { get; init; }

    [JsonPropertyName("customFromEmail")]
    public string? CustomFromEmail { get; init; }

    [JsonPropertyName("stripeCustomerId")]
    public string? StripeCustomerId { get; init; }

    [JsonPropertyName("metadata")]
    public Dictionary<string, object> Metadata { get; init; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; init; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; init; }

    [JsonPropertyName("defaultAppId")]
    public string? DefaultAppId { get; init; }

    [JsonPropertyName("dashboard")]
    public int? Dashboard { get; init; }
}
