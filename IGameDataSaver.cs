using BAP.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    /// <summary>
    /// Default interface for saving information that a game needs. This is stored in the DB and can be fetched any time the game is active.
    /// It always saves the information for the currently active game. 
    /// So if this is used by an auxilary item that kind of acts like a game it won't save and retrieve correctly. 
    /// </summary>
    public interface IGameDataSaver
    {
        public string UniqueIdUserForSaving { get; }
        Task<List<(string difficulty, string difficultyDescription)>> GetCurrentScoreBoards();
        Task<List<Score>> GetScores(string difficulty, int topScoresToTake = 10, bool higherScoreIsBetter = true);
        Task<Score> AddScore(Score newScore);
        Task<T?> GetGameStorage<T>(string key = "default");
        Task<bool> UpdateGameStorage<T>(T itemToSave, string key= "default");
        Task<List<Score>> GetScoresWithNewScoreIfWarranted(Score newScore, int topScoresToTake = 10, bool higherScoreIsBetter = true);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSavedForClassName">This is a simple way to setup the saver with a uniqueId that is always tied to the correct class/uniqueID</typeparam>
    public interface IGameDataSaver<out TSavedForClassName> : IGameDataSaver
    {

    }
}
