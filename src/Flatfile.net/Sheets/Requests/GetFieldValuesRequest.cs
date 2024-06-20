using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class GetFieldValuesRequest
{
    public string? FieldKey { get; init; }

    public string? SortField { get; init; }

    public SortDirection? SortDirection { get; init; }

    public Filter? Filter { get; init; }

    /// <summary>
    /// Name of field by which to filter records
    /// </summary>
    public string? FilterField { get; init; }

    /// <summary>
    /// Number of records to return in a page (default 1000 if pageNumber included)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// Based on pageSize, which page of records to return
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// Must be set to true
    /// </summary>
    public bool Distinct { get; init; }

    public bool? IncludeCounts { get; init; }

    /// <summary>
    /// A value to find for a given field in a sheet. Wrap the value in "" for exact match
    /// </summary>
    public string? SearchValue { get; init; }
}
