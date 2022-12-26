using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// Basic Button Provider to get information about the connected buttons.
    /// </summary>
    [BapProviderInterface("Button Provider", "Provides info about the buttons that are connected.")]
    public interface IButtonProvider : IBapProvider
    {
        List<string> GetConnectedButtons();
        List<string> GetConnectedButtonsInOrder();
        List<(string nodeId, ButtonStatus buttonStatus)> GetAllConnectedButtonInfo();
    }
}