namespace ISP.Logic
{   
    public interface IApplicationSettings
    {
        string ApplicationName { get; }
        string ApplicationVersion { get; }
        string AuthorName { get; }
    }

    public interface IDatabaseSettings
    {
        string SaPassword { get; }
        string SQLServerName { get; }
        string SQLDatabaseName { get; }
    }
}
