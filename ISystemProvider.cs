using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    [BapProviderInterface("System Provider", "Make changes to the underlying system - reboot, etc", false)]
    internal interface ISystemProvider : IBapProvider
    {
        public Task<bool> RebootSystem();
        public Task<bool> RebootWebApp();
        public Task<bool> RebootWifi();
        public Task<bool> ShutdownSystem();
    }
}
