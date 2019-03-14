using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalTarget : RemoteMemoryObject
	{
		public string Id => M.ReadStringU(M.ReadLong(Address));
		public MonsterVariety MonsterVariety => GameController.Instance.Files.MonsterVarieties.GetByAddress(M.ReadLong(Address + 0x20));
		public string Art => M.ReadStringU(M.ReadLong(Address + 0x38));
		public string FullName => M.ReadStringU(M.ReadLong(Address + 0x51));
		public string Name => M.ReadStringU(M.ReadLong(Address + 0x61));

		public override string ToString()
		{
			return Name;
		}
	}
}