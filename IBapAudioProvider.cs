using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    [BapProviderAttribute(true)]
    public interface IAudioProvider : IBapProvider, IDisposable
    {
        Task<(bool success, string message)> PlaySound(string pathToAudioFile);
    }
}
