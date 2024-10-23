namespace ISP.Logic
{
    public interface IConfigurationSettings
    {
        string ApplicationName { get; }
        string ApplicationVersion { get; }
        string AuthorName { get; }
        string SaPassword { get; }
        string SQLServerName { get; }
        string SQLDatabaseName { get; }
    }
}
