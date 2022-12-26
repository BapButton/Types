using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    [BapProviderInterface("Audio Provider", "Allows games to play sounds. Can play them in different places based on how many Audio Providers are loaded.", true)]
    public interface IAudioProvider : IBapProvider
    {
        Task<(bool success, string message)> PlaySound(string pathToAudioFile);
    }
}
