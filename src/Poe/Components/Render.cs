using SharpDX;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Render : Component
    {
        public float X => Address != 0 ? M.ReadFloat(Address + 0x78) : 0f;
        public float Y => Address != 0 ? M.ReadFloat(Address + 0x7C) : 0f;
        public float Z => Address != 0 ? M.ReadFloat(Address + 0x80) : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);

        public string Name => GetObject<NativeStringReader>(Address + 0x98).Text;
        public Vector3 Bounds => new Vector3(M.ReadFloat(Address + 0x84), M.ReadFloat(Address + 0x88), M.ReadFloat(Address + 0x8C));
        public Vector3 MeshRoration => new Vector3(M.ReadFloat(Address + 0xB8), M.ReadFloat(Address + 0xBC), M.ReadFloat(Address + 0xC0));

        public float TerrainHeight => M.ReadFloat(Address + 0xD4);
    }
}
