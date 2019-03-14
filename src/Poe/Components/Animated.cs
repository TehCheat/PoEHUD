using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Poe.Components
{
    public class Animated : Component
    {
        public Entity BaseAnimatedObjectEntity => GetObject<Entity>(M.ReadLong(Address + 0x88));
    }
}
