using SharpDX;

namespace PoeHUD.Poe.Components
{
	using Models.Attributes;

	public class Positioned : Component
	{
		public int GridX => Address != 0 ? M.ReadInt(Address + 0xEC) : 0;
		public int GridY => Address != 0 ? M.ReadInt(Address + 0xF0) : 0;
		public Vector2 GridPos => new Vector2(GridX, GridY);

		public float WorldX => M.ReadFloat(Address + 0x118);
		public float WorldY => M.ReadFloat(Address + 0x11C);
		public Vector2 WorldPos => new Vector2(WorldX, WorldY);

		public float Rotation => M.ReadFloat(Address + 0xF0); // Radians, btw
		public float RotationDeg => Rotation * (180 / MathUtil.Pi);

        public byte Reaction => M.ReadByte(Address + 0x58);
	}
}