using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class ClientAnimationController : Component
    {
        public int AnimKey => M.ReadInt(Address + 0x9c);
    }
}
