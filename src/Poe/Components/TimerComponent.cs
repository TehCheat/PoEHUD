using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class TimerComponent : Component
    {
        public float TimeLeft => M.ReadFloat(Address + 0x18);
    }
}
