using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public partial class Flatfile
{
    private RawClient _client;

    public Flatfile(string token = null, ClientOptions clientOptions = null)
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token}" },
                { "xDisableHooks", $"true" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Flatfile.net" },
                { "X-Fern-SDK-Version", "0.0.1" },
            },
            clientOptions ?? new ClientOptions()
        );
        Accounts = new AccountsClient(_client);
        Agents = new AgentsClient(_client);
        Apps = new AppsClient(_client);
        Assistant = new AssistantClient(_client);
        Commits = new CommitsClient(_client);
        Commons = new CommonsClient(_client);
        DataRetentionPolicies = new DataRetentionPoliciesClient(_client);
        Documents = new DocumentsClient(_client);
        Entitlements = new EntitlementsClient(_client);
        Environments = new EnvironmentsClient(_client);
        Events = new EventsClient(_client);
        Files = new FilesClient(_client);
        Guests = new GuestsClient(_client);
        Jobs = new JobsClient(_client);
        Mapping = new MappingClient(_client);
        Records = new RecordsClient(_client);
        Roles = new RolesClient(_client);
        Secrets = new SecretsClient(_client);
        Sheets = new SheetsClient(_client);
        Snapshots = new SnapshotsClient(_client);
        Spaces = new SpacesClient(_client);
        Users = new UsersClient(_client);
        Versions = new VersionsClient(_client);
        Views = new ViewsClient(_client);
        Workbooks = new WorkbooksClient(_client);
    }

    public AccountsClient Accounts { get; }

    public AgentsClient Agents { get; }

    public AppsClient Apps { get; }

    public AssistantClient Assistant { get; }

    public CommitsClient Commits { get; }

    public CommonsClient Commons { get; }

    public DataRetentionPoliciesClient DataRetentionPolicies { get; }

    public DocumentsClient Documents { get; }

    public EntitlementsClient Entitlements { get; }

    public EnvironmentsClient Environments { get; }

    public EventsClient Events { get; }

    public FilesClient Files { get; }

    public GuestsClient Guests { get; }

    public JobsClient Jobs { get; }

    public MappingClient Mapping { get; }

    public RecordsClient Records { get; }

    public RolesClient Roles { get; }

    public SecretsClient Secrets { get; }

    public SheetsClient Sheets { get; }

    public SnapshotsClient Snapshots { get; }

    public SpacesClient Spaces { get; }

    public UsersClient Users { get; }

    public VersionsClient Versions { get; }

    public ViewsClient Views { get; }

    public WorkbooksClient Workbooks { get; }

    private string GetFromEnvironmentOrThrow(string env, string message)
    {
        var value = System.Environment.GetEnvironmentVariable(env);
        if (value == null)
        {
            throw new Exception(message);
        }
        return value;
    }
}
