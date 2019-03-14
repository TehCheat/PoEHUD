namespace PoeHUD.Poe.Elements
{
	public class SyndicatePanel : Element
	{
		public Element EventElement => ReadObjectAt<Element>(0xAD8);
		public Element TextElement => EventElement.GetChildFromIndices(5, 1);
		public string EventText => TextElement.AsObject<EntityLabel>().Text;
	}
}
