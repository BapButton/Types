using MessagePack;
using System;

namespace BAP.Types
{
    [MessagePackObject]
    public class ButtonPress
    {
        [Key(0)]
        public bool IsLongPress { get; set; }

        [Key(1)]
        public bool StartOfPress { get; set; }
        [Key(2)]
        public bool EndOfPress { get; set; }
        [Key(3)]
        public long LengthOfPressInMillis { get; set; }
    }
}
