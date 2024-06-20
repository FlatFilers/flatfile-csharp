using System.Text.Json.Serialization;

#nullable enable

namespace Flatfile.net;

public class Pagination
{
    /// <summary>
    /// current page of results
    /// </summary>
    [JsonPropertyName("currentPage")]
    public int CurrentPage { get; init; }

    /// <summary>
    /// total number of pages of results
    /// </summary>
    [JsonPropertyName("pageCount")]
    public int PageCount { get; init; }

    /// <summary>
    /// total available results
    /// </summary>
    [JsonPropertyName("totalCount")]
    public int TotalCount { get; init; }
}
