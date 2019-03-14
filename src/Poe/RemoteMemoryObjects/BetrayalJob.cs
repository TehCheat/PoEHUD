using SharpDX;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalJob : RemoteMemoryObject
	{
		public static Vector2 TransportationLeaderPos = new Vector2(1349.853f, 577.3936f);
		public static Vector2 FortificationLeaderPos = new Vector2(1898.01f, 862.7452f);
		public static Vector2 ResearchLeaderPos = new Vector2(2515.993f, 862.7444f);
		public static Vector2 IntervensionLeaderPos = new Vector2(3064.15f, 577.3913f);

		public string Id => M.ReadStringU(M.ReadLong(Address));
		public string Name => M.ReadStringU(M.ReadLong(Address + 0x8));
		public string Art => M.ReadStringU(M.ReadLong(Address + 0x20));

		public Vector2 LeaderPos
		{
			get
			{
				switch (Name)
				{
					case "Transportation":
						return TransportationLeaderPos;
					case "Fortification":
						return FortificationLeaderPos;
					case "Research":
						return ResearchLeaderPos;
					case "Intervention":
						return IntervensionLeaderPos;
					default:
						return Vector2.Zero;
				}
			}
		}

		public override string ToString()
		{
			return Name;
		}
	}
}