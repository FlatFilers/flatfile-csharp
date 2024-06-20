using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class MutateJobConfig
{
    [JsonPropertyName("sheetId")]
    public string SheetId { get; init; }

    /// <summary>
    /// A JavaScript function that will be run on each record in the sheet, it should return a mutated record.
    /// </summary>
    [JsonPropertyName("mutateRecord")]
    public string MutateRecord { get; init; }

    /// <summary>
    /// If the mutation was generated through some sort of id-ed process, this links this job and that process.
    /// </summary>
    [JsonPropertyName("mutationId")]
    public string? MutationId { get; init; }

    /// <summary>
    /// If specified, a snapshot will be generated with this label
    /// </summary>
    [JsonPropertyName("snapshotLabel")]
    public string? SnapshotLabel { get; init; }

    /// <summary>
    /// The generated snapshotId will be stored here
    /// </summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; init; }

    [JsonPropertyName("filter")]
    public Filter? Filter { get; init; }

    [JsonPropertyName("filterField")]
    public string? FilterField { get; init; }

    [JsonPropertyName("searchValue")]
    public string? SearchValue { get; init; }

    [JsonPropertyName("searchField")]
    public string? SearchField { get; init; }

    [JsonPropertyName("q")]
    public string? Q { get; init; }

    /// <summary>
    /// The Record Ids param (ids) is a list of record ids that can be passed to several record endpoints allowing the user to identify specific records to INCLUDE in the query, or specific records to EXCLUDE, depending on whether or not filters are being applied. When passing a query param that filters the record dataset, such as 'searchValue', or a 'filter' of 'valid' | 'error' | 'all', the 'ids' param will EXCLUDE those records from the filtered results. For basic queries that do not filter the dataset, passing record ids in the 'ids' param will limit the dataset to INCLUDE just those specific records
    /// </summary>
    [JsonPropertyName("ids")]
    public IEnumerable<string>? Ids { get; init; }
}
