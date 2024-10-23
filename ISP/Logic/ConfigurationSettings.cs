using System.Configuration;

namespace ISP.Logic
{
    class AppConfigurationSettings : ConfigurationSection, IApplicationSettings
    {
        public static AppConfigurationSettings Settings { get; }

        static AppConfigurationSettings()
        {
            Settings = ConfigurationManager.GetSection("AppConfigurationSettings") as AppConfigurationSettings;
        }

        [ConfigurationProperty("ApplicationName", IsRequired = true)]
        public string ApplicationName => this["ApplicationName"] as string;

        [ConfigurationProperty("ApplicationVersion", IsRequired = true)]
        public string ApplicationVersion => this["ApplicationVersion"] as string;

        [ConfigurationProperty("AuthorName", IsRequired = true)]
        public string AuthorName => this["AuthorName"] as string;
    }

    class DbConfigurationSettings : ConfigurationSection, IDatabaseSettings
    {
        public static DbConfigurationSettings Settings { get; }

        static DbConfigurationSettings()
        {
            Settings = ConfigurationManager.GetSection("DbConfigurationSettings") as DbConfigurationSettings;
        }

        [ConfigurationProperty("SaPassword", IsRequired = true)]
        public string SaPassword => this["SaPassword"] as string;

        [ConfigurationProperty("SQLServerName", IsRequired = true)]
        public string SQLServerName => this["SQLServerName"] as string;

        [ConfigurationProperty("SQLDatabaseName", IsRequired = true)]
        public string SQLDatabaseName => this["SQLDatabaseName"] as string;
    }
}
