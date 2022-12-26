using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Types
{
    [BapProviderInterface("Layout Provider", "Allows the setting and fetching of Layouts for the button. This allows games to understand how buttons are layed out compared to other buttons")]
    public interface ILayoutProvider : IBapProvider
    {
        ButtonLayout? SetNewButtonLayout(ButtonLayout? bl);
        ButtonLayout? CurrentButtonLayout { get; }
    }
}
