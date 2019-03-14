using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalChoiceAction : RemoteMemoryObject
	{
		public string Id => M.ReadStringU(M.ReadLong(Address));
		public BetrayalChoice Choice => GameController.Instance.Files.BetrayalChoises.GetByAddress(M.ReadLong(Address + 0x10));

		public override string ToString()
		{
			return $"{Id} ({Choice.Name})";
		}
	}
}
