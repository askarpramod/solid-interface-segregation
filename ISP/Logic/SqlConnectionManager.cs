using System.Data.SqlClient;
using System.IO;

namespace ISP.Logic
{
    public class SqlConnectionManager
    {
        private readonly IConfigurationSettings _configurationSettings;

        public SqlConnectionManager(IConfigurationSettings configurationSettings)
        {
            _configurationSettings = configurationSettings;
        }

        public SqlConnectionManager() : this(ConfigurationSettings.Settings)
        { }

        public void Connect()
        {
            var myConnection = new SqlConnection($"user id=sa; password={_configurationSettings?.SaPassword};" +
             $"server={ _configurationSettings?.SQLServerName}; Trusted_Connection=yes; database={_configurationSettings?.SQLDatabaseName}; connection timeout=30");

            myConnection.Open();
        }

        public void ConnectionInfo(TextWriter writer)
        {
            writer.Write($"user id=sa; password={_configurationSettings?.SaPassword}; " +
             $"server={ _configurationSettings?.SQLServerName}; Trusted_Connection=yes; database={_configurationSettings?.SQLDatabaseName}; connection timeout=30");
        }
    }
}
