using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// Basic interface for BapProviders. This is to help with listing and changing the providers. 
    /// </summary>
    public interface IBapProvider : IDisposable
    {
        string Name { get; }
        bool AllowMultiple { get; set; }
        Task<bool> InitializeAsync();
    }
}
