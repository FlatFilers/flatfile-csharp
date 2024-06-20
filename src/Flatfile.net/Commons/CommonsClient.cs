using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class CommonsClient
{
    private RawClient _client;

    public CommonsClient(RawClient client)
    {
        _client = client;
    }
}
