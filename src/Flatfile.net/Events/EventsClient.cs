using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class EventsClient
{
    private RawClient _client;

    public EventsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Event topics that the Flatfile Platform emits.
    /// </summary>
    public async Task<ListAllEventsResponse> ListAsync(ListEventsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.EnvironmentId != null)
        {
            _query["environmentId"] = request.EnvironmentId;
        }
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        if (request.Domain != null)
        {
            _query["domain"] = request.Domain;
        }
        if (request.Topic != null)
        {
            _query["topic"] = request.Topic;
        }
        if (request.Since != null)
        {
            _query["since"] = request.Since;
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize;
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber;
        }
        if (request.IncludeAcknowledged != null)
        {
            _query["includeAcknowledged"] = request.IncludeAcknowledged;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/events",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListAllEventsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<EventResponse> CreateAsync(CreateEventConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/events",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EventResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<EventResponse> GetAsync(string eventId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/events/{eventId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EventResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<Success> AckAsync(string eventId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/events/{eventId}/ack" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get a token which can be used to subscribe to events for this space
    /// </summary>
    public async Task<EventTokenResponse> GetEventTokenAsync(GetEventTokenRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Scope != null)
        {
            _query["scope"] = request.Scope;
        }
        if (request.SpaceId != null)
        {
            _query["spaceId"] = request.SpaceId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/subscription",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EventTokenResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
