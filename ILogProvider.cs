using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    [BapProviderInterface("Log Provider", "Ability to access any logs across the system.", false)]
    public interface ILogProvider : IBapProvider
    {
        List<LogMessage> GetCurrentLogs();
        List<LogMessage> GetLogs(LogLevel logLevel, int numberToFetch);
    }
}
