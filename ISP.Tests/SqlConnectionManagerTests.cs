using Moq;
using NUnit.Framework;
using System.Data.SqlClient;
using System.IO;
using ISP.Logic;

namespace ISP.Tests
{
    public class SqlConnectionManagerTests
    {
        [Test]
        public void ConnectionFails()
        {
            var mock = new Mock<IDatabaseSettings>();
            mock.Setup(m => m.SaPassword).Returns("Ep@m2017!");
            mock.Setup(m => m.SQLServerName).Returns("localhost");
            mock.Setup(m => m.SQLDatabaseName).Returns("ISP");

            var sqlConnectionManager = new SqlConnectionManager(mock.Object);
            Assert.Throws<SqlException>(sqlConnectionManager.Connect);
        }

        [Test]
        public void ConnectionSettingsAreRenderedCorrectly()
        {
            var mock = new Mock<IDatabaseSettings>();
            mock.Setup(m => m.SaPassword).Returns("Ep@m2017!");
            mock.Setup(m => m.SQLServerName).Returns("localhost");
            mock.Setup(m => m.SQLDatabaseName).Returns("ISP");

            var sqlConnectionManager = new SqlConnectionManager(mock.Object);
            var textWriter = new StringWriter();

            sqlConnectionManager.ConnectionInfo(textWriter);
            Assert.AreEqual("user id=sa; password=Ep@m2017!; server=localhost; Trusted_Connection=yes; database=ISP; connection timeout=30",
                textWriter.ToString());
        }
    }
}
