using MessagePack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    [MessagePackObject]
    public class ButtonSettings
    {
        [Key(0)]
        public bool SendReleaseMessage { get; set; }
        [Key(1)]
        public string AlternateWifiSSID { get; set; } = "";
        [Key(2)]
        public string AlternateWifiPassword { get; set; } = "";
        [Key(3)]
        public ushort MinBatteryLevel { get; set; }
        [Key(4)]
        public ushort PressSensitivity { get; set; }
    }
}
