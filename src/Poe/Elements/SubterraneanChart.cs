namespace PoeHUD.Poe.Elements
{
    public class SubterraneanChart : Element
    {
        public Element GridElement => Address != 0 ? GetObject<Element>(M.ReadLong(Address + 0x1C0, 0x690/* + 0x9A8, 0x110, 0x178, 0x178, 0x178, 0x178, 0x10*/)) : null;
    }
}
