using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Logic
{
    // Interface for database-specific settings
    public interface IDatabaseConfiguration
    {
        string SaPassword { get; }
        string SQLServerName { get; }
        string SQLDatabaseName { get; }
    }
}
