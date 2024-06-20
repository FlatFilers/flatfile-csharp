using System.Text.Json;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class JobsClient
{
    private RawClient _client;

    public JobsClient(RawClient client)
    {
        _client = client;
    }

    public async Task<ListJobsResponse> ListAsync(ListJobsRequest request)
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
        if (request.WorkbookId != null)
        {
            _query["workbookId"] = request.WorkbookId;
        }
        if (request.FileId != null)
        {
            _query["fileId"] = request.FileId;
        }
        if (request.ParentId != null)
        {
            _query["parentId"] = request.ParentId;
        }
        if (request.PageSize != null)
        {
            _query["pageSize"] = request.PageSize;
        }
        if (request.PageNumber != null)
        {
            _query["pageNumber"] = request.PageNumber;
        }
        if (request.SortDirection != null)
        {
            _query["sortDirection"] = request.SortDirection;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ListJobsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<JobResponse> CreateAsync(JobConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<JobResponse> GetAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{jobId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<JobResponse> UpdateAsync(string jobId, JobUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/{jobId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    public async Task<Success> DeleteAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Delete, Path = $"/{jobId}" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Execute a job and return the job
    /// </summary>
    public async Task<Success> ExecuteAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/{jobId}/execute" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Success>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a single job's execution plan
    /// </summary>
    public async Task<JobPlanResponse> GetExecutionPlanAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = $"/{jobId}/plan" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobPlanResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update a job's entire execution plan
    /// </summary>
    public async Task<JobPlanResponse> UpdateExecutionPlanAsync(
        string jobId,
        JobExecutionPlanRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/{jobId}/plan",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobPlanResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update one or more individual fields on a job's execution plan
    /// </summary>
    public async Task<JobPlanResponse> UpdateExecutionPlanFieldsAsync(
        string jobId,
        JobExecutionPlanConfigRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"/{jobId}/plan",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobPlanResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Acknowledge a job and return the job
    /// </summary>
    public async Task<JobResponse> AckAsync(string jobId, JobAckDetails? request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{jobId}/ack",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Acknowledge a job outcome and return the job
    /// </summary>
    public async Task<JobResponse> AckOutcomeAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/{jobId}/outcome/ack" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Complete a job and return the job
    /// </summary>
    public async Task<JobResponse> CompleteAsync(string jobId, JobCompleteDetails? request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{jobId}/complete",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Fail a job and return the job
    /// </summary>
    public async Task<JobResponse> FailAsync(string jobId, JobCompleteDetails? request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{jobId}/fail",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Cancel a job and return the job
    /// </summary>
    public async Task<JobResponse> CancelAsync(string jobId, JobCancelDetails? request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{jobId}/cancel",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retry a failt job and return the job
    /// </summary>
    public async Task<JobResponse> RetryAsync(string jobId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Post, Path = $"/{jobId}/retry" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Preview the results of a mutation
    /// </summary>
    public async Task<DiffRecordsResponse> PreviewMutationAsync(MutateJobConfig request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/preview-mutation",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<DiffRecordsResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Split a job and return the job
    /// </summary>
    public async Task<JobResponse> SplitAsync(string jobId, JobSplitDetails request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/{jobId}/split",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<JobResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
