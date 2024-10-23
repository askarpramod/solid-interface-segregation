using System.IO;
using ISP.Logic;

namespace ISP
{
    public class AboutMyApp
    {
        private readonly IConfigurationSettings _configurationSettings;

        public AboutMyApp(IConfigurationSettings configurationSettings)
        {
            _configurationSettings = configurationSettings;
        }

        public AboutMyApp()
            : this(ConfigurationSettings.Settings)
        { }

        public void Render(TextWriter writer)
        {
            writer.Write($"{_configurationSettings?.ApplicationName} v.{_configurationSettings?.ApplicationVersion} by {_configurationSettings?.AuthorName}");
        }
    }
}
