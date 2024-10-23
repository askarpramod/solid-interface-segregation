using System.Configuration;

namespace ISP.Logic
{
    class ConfigurationSettings : ConfigurationSection, IConfigurationSettings
    {
        public static ConfigurationSettings Settings { get; }

        static ConfigurationSettings()
        {
            Settings = ConfigurationManager.GetSection("ConfigurationSettings") as ConfigurationSettings;
        }

        [ConfigurationProperty("ApplicationName", IsRequired = true)]
        public string ApplicationName
        {
            get { return this["ApplicationName"] as string; }
        }

        [ConfigurationProperty("ApplicationVersion", IsRequired = true)]
        public string ApplicationVersion
        {
            get { return this["ApplicationVersion"] as string; }
        }

        [ConfigurationProperty("AuthorName", IsRequired = true)]
        public string AuthorName
        {
            get { return this["AuthorName"] as string; }
        }

        [ConfigurationProperty("SaPassword", IsRequired = true)]
        public string SaPassword
        {
            get { return this["SaPassword"] as string; }
        }

        [ConfigurationProperty("SQLServerName", IsRequired = true)]
        public string SQLServerName
        {
            get { return this["SQLServerName"] as string; }
        }

        [ConfigurationProperty("SQLDatabaseName", IsRequired = true)]
        public string SQLDatabaseName
        {
            get { return this["SQLDatabaseName"] as string; }
        }
    }
}
