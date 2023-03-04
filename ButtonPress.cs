using MessagePack;
using System;

namespace BAP.Types
{
    [MessagePackObject]
    public class ButtonPress
    {
        //0 Means Release of the Button
        [Key(0)]
        public bool StartOfPress { get; set; }
        //This would only ever be over 0 if StartOfPress is set to 0
        [Key(1)]
        public long LengthOfPressInMillis { get; set; }
    }
}
