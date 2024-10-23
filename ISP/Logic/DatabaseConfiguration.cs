using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Logic
{
    class DatabaseConfiguration : ConfigurationSection, IDatabaseConfiguration
    {
        public static DatabaseConfiguration Settings { get; }

        static DatabaseConfiguration()
        {
            Settings = ConfigurationManager.GetSection("DatabaseConfiguration") as DatabaseConfiguration;
        }

        [ConfigurationProperty("SaPassword", IsRequired = true)]
        public string SaPassword => this["SaPassword"] as string;

        [ConfigurationProperty("SQLServerName", IsRequired = true)]
        public string SQLServerName => this["SQLServerName"] as string;

        [ConfigurationProperty("SQLDatabaseName", IsRequired = true)]
        public string SQLDatabaseName => this["SQLDatabaseName"] as string;
    }
}
