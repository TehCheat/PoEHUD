using System;
using SharpDX;

namespace PoeHUD.Poe
{
    public class Pathfinding : Component
    {
        public Vector2 TargetMovePos => new Vector2(M.ReadInt(Address + 0x28), M.ReadInt(Address + 0x2C));
        public Vector2 PreviousMovePos => new Vector2(M.ReadInt(Address + 0x30), M.ReadInt(Address + 0x34));
        public bool IsMoving => M.ReadInt(Address + 0x4ac) == 1;
    }
}
