using System.IO;
using ISP.Logic;

namespace ISP
{
    public class AboutMyApp
    {
        private readonly IApplicationSettings _applicationSettings;

        public AboutMyApp(IApplicationSettings applicationSettings)
        {
            _applicationSettings = applicationSettings;
        }

        public AboutMyApp() : this(ApplicationConfiguration.Settings) { }

        public void Render(TextWriter writer)
        {
            writer.Write($"{_applicationSettings?.ApplicationName} v.{_applicationSettings?.ApplicationVersion} by {_applicationSettings?.AuthorName}");
        }
    }
}
