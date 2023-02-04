using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// There is a singleton IGameHandler that keeps track of the current game and is responsible for showing it's component. 
    /// Also, it can swap out and end the current game. 
    /// </summary>
    /// 
    [BapProviderInterface("Game Provider", "Holds Games in memory and can load and unload games.", false)]
    public interface IGameProvider : IBapProvider
    {
        IBapGame? CurrentGame { get; }
        bool IsGameRunning { get; }
        bool IsGameSelected { get; }
        Task ForceGameEnd();
        Task DeselectGame();
        T ReturnGameWithoutEnabling<T>();
        string CurrentGameName { get; }
        string CurrentGameUniqueId { get; }
        string CurrentGameDescription { get; }
        IBapGame UpdateToNewGameType(Type gameType, bool createNewGameIfSameTypeLoaded = false);
        Type? DynamicComponentToLoad { get; }
        bool UpdateDynamicComponentToLoad(Type pageToLoad, string gameName, string gameDescription, string gameUniqueId);
    }
}