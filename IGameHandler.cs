using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// There is a singleton IGameHandler that keeps track of the current game and is responsible for showing it's component. 
    /// Also, it can swap out and end the current game. 
    /// </summary>
    public interface IGameHandler
    {
        IBapGame? CurrentGame { get; }
        bool IsGameRunning { get; }
        bool IsGameSelected { get; }
        Task ForceGameEnd();
        public string CurrentGameName { get; }
        public string CurrentGameUniqueId { get; }
        public string CurrentGameDescription { get; }
        IBapGame UpdateToNewGameType(Type gameType, bool createNewGameIfSameTypeLoaded = false);
        public Type? DynamicComponentToLoad { get; }
        public bool UpdateDynamicComponentToLoad(Type pageToLoad, string gameName, string gameDescription, string gameUniqueId);
    }
}