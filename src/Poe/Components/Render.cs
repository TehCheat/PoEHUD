using SharpDX;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    public class Render : Component
    {
        public float X => Address != 0 ? M.ReadFloat(Address + 0x70) : 0f;
        public float Y => Address != 0 ? M.ReadFloat(Address + 0x74) : 0f;
        public float Z => Address != 0 ? M.ReadFloat(Address + 0x78) : 0f;
        public Vector3 Pos => new Vector3(X, Y, Z);

        public string Name => ReadObject<NativeStringReader>(Address + 0x90).Value;
        public Vector3 Bounds => new Vector3(M.ReadFloat(Address + 0x7C), M.ReadFloat(Address + 0x80), M.ReadFloat(Address + 0x84));
        public Vector3 MeshRoration => new Vector3(M.ReadFloat(Address + 0x98), M.ReadFloat(Address + 0x9C), M.ReadFloat(Address + 0xA0));

        public float TerrainHeight => M.ReadFloat(Address + 0xCC);
    }
}