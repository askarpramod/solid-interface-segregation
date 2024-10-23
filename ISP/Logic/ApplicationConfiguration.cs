using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Logic
{
    class ApplicationConfiguration : ConfigurationSection, IApplicationSettings
    {
        public static ApplicationConfiguration Settings { get; }

        static ApplicationConfiguration()
        {
            Settings = ConfigurationManager.GetSection("ApplicationConfiguration") as ApplicationConfiguration;
        }

        [ConfigurationProperty("ApplicationName", IsRequired = true)]
        public string ApplicationName => this["ApplicationName"] as string;

        [ConfigurationProperty("ApplicationVersion", IsRequired = true)]
        public string ApplicationVersion => this["ApplicationVersion"] as string;

        [ConfigurationProperty("AuthorName", IsRequired = true)]
        public string AuthorName => this["AuthorName"] as string;
    }
}
