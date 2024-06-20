using System.Text.Json.Serialization;
using Flatfile.net;
using Flatfile.net.Core;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class FindAndReplaceJobConfig
{
    /// <summary>
    /// The filter to apply to the records
    /// </summary>
    [JsonPropertyName("filter")]
    public Filter? Filter { get; init; }

    /// <summary>
    /// The field to filter on
    /// </summary>
    [JsonPropertyName("filterField")]
    public string? FilterField { get; init; }

    /// <summary>
    /// The value to search for
    /// </summary>
    [JsonPropertyName("searchValue")]
    public string? SearchValue { get; init; }

    /// <summary>
    /// The field to search for the search value in
    /// </summary>
    [JsonPropertyName("searchField")]
    public string? SearchField { get; init; }

    /// <summary>
    /// The FFQL query to filter records
    /// </summary>
    [JsonPropertyName("q")]
    public string? Q { get; init; }

    /// <summary>
    /// The Record Ids param (ids) is a list of record ids that can be passed to several record endpoints allowing the user to identify specific records to INCLUDE in the query, or specific records to EXCLUDE, depending on whether or not filters are being applied. When passing a query param that filters the record dataset, such as 'searchValue', or a 'filter' of 'valid' | 'error' | 'all', the 'ids' param will EXCLUDE those records from the filtered results. For basic queries that do not filter the dataset, passing record ids in the 'ids' param will limit the dataset to INCLUDE just those specific records
    /// </summary>
    [JsonPropertyName("ids")]
    public IEnumerable<string>? Ids { get; init; }

    /// <summary>
    /// A value to find for a given field in a sheet. Wrap the value in "" for exact match
    /// </summary>
    [JsonPropertyName("find")]
    [JsonConverter(
        typeof(OneOfSerializer<OneOf<string, int, long, double, bool, DateOnly, DateTime>>)
    )]
    public OneOf<string, int, long, double, bool, DateOnly, DateTime>? Find { get; init; }

    /// <summary>
    /// The value to replace found values with
    /// </summary>
    [JsonPropertyName("replace")]
    [JsonConverter(
        typeof(OneOfSerializer<OneOf<string, int, long, double, bool, DateOnly, DateTime>>)
    )]
    public OneOf<string, int, long, double, bool, DateOnly, DateTime>? Replace { get; init; }

    /// <summary>
    /// A unique key used to identify a field in a sheet
    /// </summary>
    [JsonPropertyName("fieldKey")]
    public string FieldKey { get; init; }
}
