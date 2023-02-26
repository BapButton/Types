using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    public class LogMessage
    {
        public int MessageId { get; set; }
        public string Source { get; set; }
        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public LogMessage(int messageId, string source, LogLevel level, string message)
        {
            MessageId = messageId;
            Source = source;
            Level = level;
            Message = message;
        }
    }


    /// <summary>
    /// This is a basic Game Event Message to communicate between a game and the hosting page. 
    /// If your Game page implements the GamePage interface it will be automatically passed into the GameUpdateAsync method.
    /// </summary>
    public class GameEventMessage
    {
        public bool GameEnded { get; set; }
        public string Message { get; set; }
        public bool HighScoreAchieved { get; set; }
        public bool PageRefreshRecommended { get; set; }
        public bool FatalError { get; set; }
        public GameEventMessage(bool gameEnded, string message = "", bool highScoreAchieved = false, bool fatalError = false, bool pageRefreshRecommended = false)
        {
            GameEnded = gameEnded;
            Message = message;
            HighScoreAchieved = highScoreAchieved;
            FatalError = fatalError;
            PageRefreshRecommended = pageRefreshRecommended;
        }
    }
    /// <summary>
    /// Basic message to Play Audio from the Current Game
    /// Use the helper utilities to figure out the full path based on your class to figure out where the nuget is mounted in the system
    /// </summary>
    public class PlayAudioMessage
    {
        public string FullPathToAudioFileWithFileName { get; set; }
        public bool StopAllPlayingAudio { get; set; }
        public bool ClearAllCachedAudio { get; set; }
        public PlayAudioMessage(string fileName, bool stopAllPlayingAudio = false, bool clearAllCachedAudio = false)
        {
            StopAllPlayingAudio = stopAllPlayingAudio;
            ClearAllCachedAudio = clearAllCachedAudio;
            FullPathToAudioFileWithFileName = fileName;
        }
    }


    /// <summary>
    /// Message whenever a Node is Pressed
    /// </summary>
    public class ButtonPressedMessage
    {
        public string NodeId { get; set; }
        public ButtonPress ButtonPress { get; set; }
        public ButtonPressedMessage(string nodeId, ButtonPress buttonPress)
        {
            NodeId = nodeId;
            ButtonPress = buttonPress;
        }
    }
    /// <summary>
    ///Slighly abstracted messaage for receiving Keypresses from a Keyboard. 
    /// </summary>
    public class KeyboardKeyPressedMessage
    {
        public char KeyValue { get; set; }
        public ButtonPress ButtonPress { get; set; }
        public KeyboardKeyPressedMessage(char keyValue, ButtonPress buttonPress)
        {
            KeyValue = keyValue;
            ButtonPress = buttonPress;
        }
    }
    /// <summary>
    /// Basic message that could be used to communicate between a game and the page. 
    /// Nothing uses this by default
    /// </summary>
    public class InternalSimpleGameUpdates
    {
        public int CorrectScore { get; set; }
        public int WrongScore { get; set; }
        public bool GameEnded { get; set; }
        public string ExtraData { get; set; }
        public InternalSimpleGameUpdates(int correctScore, int wrongScore, bool gameEnded, string extraData)
        {
            CorrectScore = correctScore;
            WrongScore = wrongScore;
            GameEnded = gameEnded;
            ExtraData = extraData;
        }
    }
    /// <summary>
    /// Triggered whenever the layout changes. 
    /// If your game needs to react to layout changes during the game play subscribe to this message.
    /// </summary>
    public class LayoutChangeMessage
    {
        public int NewButtonLayoutId { get; set; }
        public LayoutChangeMessage(int newButtonLayoutId)
        {
            NewButtonLayoutId = newButtonLayoutId;
        }
    }
    /// <summary>
    /// Alerts if a node is added or removed.
    /// If game play needs to modified based on these events subscribe to these messages
    /// </summary>
    public class NodeChangeMessage
    {
        public string NodeId { get; set; }
        public bool IsRemoved { get; set; }
        public NodeChangeMessage(string nodeId, bool isRemoved)
        {
            NodeId = nodeId;
            IsRemoved = isRemoved;
        }
    }

    /// <summary>
    /// Used by the default Animation Controller to alert that it has completed sending all images for the requested animation.
    /// </summary>
    public class AnimationCompleteMessage
    {
        public List<string> NodeIds { get; set; }
        public AnimationCompleteMessage(List<string> nodeIds)
        {
            NodeIds = nodeIds;
        }
    }

    /// <summary>
    /// Sends a command to a button to restart. If nodeId is blank then all buttons restart
    /// </summary>
    public class RestartButtonMessage
    {
        public string NodeId { get; set; }
        public RestartButtonMessage(string nodeId = "")
        {
            NodeId = nodeId;
        }
    }
    /// <summary>
    /// Sends a command to a button to turnOff. If nodeId is blank then all buttons turnoff
    /// </summary>
    public class TurnOffButtonMessage
    {
        public string NodeId { get; set; }
        public TurnOffButtonMessage(string nodeId = "")
        {
            NodeId = nodeId;
        }
    }
    /// <summary>
    /// Sends a command to a button to send a status message. If nodeId is blank then all buttons will send a status message
    /// </summary>
    public class StatusButtonMessage
    {
        public string NodeId { get; set; }
        public StatusButtonMessage(string nodeId = "")
        {
            NodeId = nodeId;
        }
    }
    /// <summary>
    /// Sends an image to the buttons. If nodeId is blank then it will go to all buttons. 
    /// The buttons will display the image the moment the recieve it
    /// </summary>
    public class StandardButtonImageMessage
    {
        public string NodeId { get; set; }
        public ButtonImage ButtonImage { get; set; }
        public StandardButtonImageMessage(ButtonImage buttonImage, string nodeId = "")
        {
            ButtonImage = buttonImage;
            NodeId = nodeId;
        }

    }

}
