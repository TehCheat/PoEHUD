namespace PoeHUD.Poe.Elements
{
	public class WorldMapElement : Element
	{
		public Element Panel => GetObject<Element>(M.ReadLong(Address + 0xAB8, 0xC10));
	}
}
