namespace Flatfile.net;

public class DeleteRecordsRequest
{
    /// <summary>
    /// A list of record IDs to delete. Maximum of 100 allowed.
    /// </summary>
    public string Ids { get; init; }
}
