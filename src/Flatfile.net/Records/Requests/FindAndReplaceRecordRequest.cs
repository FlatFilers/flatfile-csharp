using Flatfile.net;
using OneOf;

#nullable enable

namespace Flatfile.net;

public class FindAndReplaceRecordRequest
{
    public Filter? Filter { get; init; }

    /// <summary>
    /// Name of field by which to filter records
    /// </summary>
    public string? FilterField { get; init; }

    public string? SearchValue { get; init; }

    public string? SearchField { get; init; }

    /// <summary>
    /// The Record Ids param (ids) is a list of record ids that can be passed to several record endpoints allowing the user to identify specific records to INCLUDE in the query, or specific records to EXCLUDE, depending on whether or not filters are being applied. When passing a query param that filters the record dataset, such as 'searchValue', or a 'filter' of 'valid' | 'error' | 'all', the 'ids' param will EXCLUDE those records from the filtered results. For basic queries that do not filter the dataset, passing record ids in the 'ids' param will limit the dataset to INCLUDE just those specific records
    /// </summary>
    public string? Ids { get; init; }

    /// <summary>
    /// An FFQL query used to filter the result set
    /// </summary>
    public string? Q { get; init; }

    /// <summary>
    /// A value to find for a given field in a sheet. For exact matches, wrap the value in double quotes ("Bob")
    /// </summary>
    public OneOf<string, int, long, double, bool, DateOnly, DateTime>? Find { get; init; }

    /// <summary>
    /// The value to replace found values with
    /// </summary>
    public OneOf<string, int, long, double, bool, DateOnly, DateTime>? Replace { get; init; }

    /// <summary>
    /// A unique key used to identify a field in a sheet
    /// </summary>
    public string FieldKey { get; init; }
}
