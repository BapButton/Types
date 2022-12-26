using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// Basic interface for BapProviders. This is to help with listing and changing the providers. 
    /// A Provider should implement this Interface and also needs to have the BapProviderAttribute as well.
    /// </summary>
    public interface IBapProvider : IDisposable
    {
        Task<bool> InitializeAsync();
    }
}
