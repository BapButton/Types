using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// Basic Button Provider to get information about the connected buttons.
    /// </summary>
    [BapProviderAttribute(false)]
    public interface IButtonProvider : IBapProvider, IDisposable
    {
        List<string> GetConnectedButtons();
        List<string> GetConnectedButtonsInOrder();
        List<(string nodeId, ButtonStatus buttonStatus)> GetAllConnectedButtonInfo();
    }
}