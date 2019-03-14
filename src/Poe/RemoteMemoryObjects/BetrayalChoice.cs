namespace PoeHUD.Poe.RemoteMemoryObjects
{
	public class BetrayalChoice : RemoteMemoryObject
	{
		public string Id => M.ReadStringU(M.ReadLong(Address));
		public string Name => M.ReadStringU(M.ReadLong(Address + 0x8));

		public override string ToString()
		{
			return Name;
		}
	}
}
