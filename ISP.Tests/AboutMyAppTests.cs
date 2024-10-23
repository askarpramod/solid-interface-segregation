using Moq;
using NUnit.Framework;
using System.IO;
using ISP.Logic;

namespace ISP.Tests
{
    public class AboutMyAppTests
    {
        [Test]
        public void RenderAppInfoFromSettings()
        {
            var mock = new Mock<IApplicationSettings>();
            mock.Setup(m => m.ApplicationName).Returns("ISP task");
            mock.Setup(m => m.ApplicationVersion).Returns("0.012");
            mock.Setup(m => m.AuthorName).Returns("Jane Stewart");

            var aboutMyApp = new AboutMyApp(mock.Object);
            var textWriter = new StringWriter();

            aboutMyApp.Render(textWriter);
            Assert.AreEqual("ISP task v.0.012 by Jane Stewart", textWriter.ToString());
        }
    }
}
