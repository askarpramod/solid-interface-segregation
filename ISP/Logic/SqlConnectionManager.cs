using System.Data.SqlClient;
using System.IO;

namespace ISP.Logic
{
    public class SqlConnectionManager
    {
        private readonly IDatabaseSettings _databaseSettings;

        public SqlConnectionManager(IDatabaseSettings databaseSettings)
        {
            _databaseSettings = databaseSettings;
        }

        public SqlConnectionManager() : this(DbConfigurationSettings.Settings) { }

        public void Connect()
        {
            var myConnection = new SqlConnection(
                $"user id=sa; password={_databaseSettings?.SaPassword};" +
                $"server={_databaseSettings?.SQLServerName}; Trusted_Connection=yes; database={_databaseSettings?.SQLDatabaseName}; connection timeout=10");

            myConnection.Open();
        }

        public void ConnectionInfo(TextWriter writer)
        {
            writer.Write($"user id=sa; password={_databaseSettings?.SaPassword}; " +
                         $"server={_databaseSettings?.SQLServerName}; Trusted_Connection=yes; database={_databaseSettings?.SQLDatabaseName}; connection timeout=30");
        }
    }
}
